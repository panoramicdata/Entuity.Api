using AwesomeAssertions;
using Entuity.Api.Collections;
using Entuity.Api.Enums;
using Entuity.Api.JsonConverters;
using Entuity.Api.Models.CredentialManagementData.CredentialTypes;
using Entuity.Api.Models.IpamData.Get;
using Entuity.Api.QueryParameters;
using System.Text.Json;

namespace Entuity.Api.Test;

public class ModelTests
{
	private static readonly JsonSerializerOptions Options = new() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };

	private static IEnumerable<Type> ConcreteModelTypes()
		=> typeof(EntuityClient).Assembly
			.GetExportedTypes()
			.Where(type => type is { IsClass: true, IsAbstract: false, IsGenericTypeDefinition: false }
				&& type.GetConstructor(Type.EmptyTypes) is not null
				&& type.Namespace?.StartsWith("Entuity.Api.Models", StringComparison.Ordinal) == true);

	[Fact]
	public void EveryModel_CanBeConstructedAndSerialized()
	{
		var failures = new List<string>();

		foreach (var type in ConcreteModelTypes())
		{
			try
			{
				var instance = Activator.CreateInstance(type);
				JsonSerializer.Serialize(instance, type, Options).Should().NotBeNullOrEmpty();
			}
			catch (Exception ex)
			{
				failures.Add($"{type.FullName}: {ex.GetType().Name}");
			}
		}

		failures.Should().BeEmpty();
	}

	[Fact]
	public void Collections_HaveEmptyDefaults()
	{
		new BasicResponse<int>().Items.Should().BeEmpty();
		new BasicResponse<int>().Count.Should().Be(0);
		new SettingsResponse<StubItem>().Settings.Should().BeEmpty();
		new ListResponse<StubItem>().Should().BeEmpty();
	}

	[Fact]
	public void UpperCaseEnumConverter_ReadsCaseInsensitively_AndWritesEnumMemberValue()
	{
		var credential = JsonSerializer.Deserialize<CliAccessCredential>("""{"method":"telnet","username":"u"}""", Options);

		credential!.Method.Should().Be(CliAccessCredentialMethod.Telnet);
		JsonSerializer.Serialize(credential, Options).Should().Contain("\"TELNET\"");
	}

	[Fact]
	public void UpperCaseEnumConverter_WithoutEnumMember_WritesUpperCaseName()
	{
		var options = new JsonSerializerOptions { Converters = { new UpperCaseEnumConverter<SeverityRating>() } };

		JsonSerializer.Serialize(SeverityRating.Major, options).Should().Be("\"MAJOR\"");
		JsonSerializer.Deserialize<SeverityRating>("\"critical\"", options).Should().Be(SeverityRating.Critical);
	}

	[Fact]
	public void UpperCaseEnumConverter_UnknownValue_Throws()
	{
		var options = new JsonSerializerOptions { Converters = { new UpperCaseEnumConverter<SeverityRating>() } };

		var act = () => JsonSerializer.Deserialize<SeverityRating>("\"nonsense\"", options);

		act.Should().Throw<JsonException>().WithMessage("*nonsense*");
	}

	[Fact]
	public void IpamConverter_ReadsNestedArray_AndWritesItBack()
	{
		const string json = """[["Active","Idle"],{"dhcpScanPeriodHours":3,"activeTimeframeHours":24}]""";

		var response = JsonSerializer.Deserialize<IpamSettingsAndStatusResponse>(json, Options)!;

		response.Statuses.Should().Equal("Active", "Idle");
		response.Settings.DhcpScanPeriodHours.Should().Be(3);
		response.Settings.ActiveTimeframeHours.Should().Be(24);

		var roundTrip = JsonSerializer.Deserialize<IpamSettingsAndStatusResponse>(JsonSerializer.Serialize(response, Options), Options)!;
		roundTrip.Statuses.Should().Equal(response.Statuses);
		roundTrip.Settings.DhcpScanPeriodHours.Should().Be(3);
	}

	[Theory]
	[InlineData("""{"statuses":[]}""", "StartArray")]
	[InlineData("""[["a"],{},1]""", "EndArray")]
	[InlineData("""[null,{}]""", "statuses")]
	[InlineData("""[["a"],null]""", "settings")]
	public void IpamConverter_MalformedInput_Throws(string json, string expected)
	{
		var act = () => JsonSerializer.Deserialize<IpamSettingsAndStatusResponse>(json, Options);

		act.Should().Throw<JsonException>().WithMessage($"*{expected}*");
	}

	[Fact]
	public void Filters_MaskReflectsSeverityRating()
	{
		new EventsFilter().Mask.Should().BeNull();
		new IncidentsFilter().Mask.Should().BeNull();
		new EventsFilter { SeverityRating = SeverityRating.Severe }.Mask.Should().Be(8);
		new IncidentsFilter { SeverityRating = SeverityRating.Critical }.Mask.Should().Be(16);
	}

	private sealed class StubItem : Entuity.Api.Interfaces.IGetItem;
}
