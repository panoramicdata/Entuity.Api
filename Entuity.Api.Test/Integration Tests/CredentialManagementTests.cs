using Entuity.Api.Enums;
using Entuity.Api.Models.CredentialManagementData.CredentialTypes;
using Entuity.Api.Models.CredentialManagementData.Post;
using Entuity.Api.Models.CredentialManagementData.Post.CredentialAttributeSets;
using FluentAssertions;

namespace Entuity.Api.Test.Integration_Tests;
public class CredentialManagementTests(EntuityClient client) : TestFixture
{
	[Fact]
	public async Task CredentialManagementController_GetAllCredentialsAsync_ReturnsCredentials()
	{
		var response = await client
			.CredentialManagement
			.GetAllCredentialsAsync(default);

		response.Should().NotBeNull();
	}

	[Fact]
	public async Task CredentialManagementController_CreateCredentialAsync_CreateSNMPv1Credential_Succeeds()
	{
		var newSnmpCredential = new NewSnmpV1CredentialAttributes()
		{
			SnmpV1Attributes = new SnmpV1Credential()
			{
				Community = "public",
				WriteCommunity = "write"
			}
		};

		var response = await client
			.CredentialManagement
			.CreateCredentialAsync(
			new CredentialCreate<NewSnmpV1CredentialAttributes>
			{
				Name = "SNMPv1 Test Credential",
				Attributes = newSnmpCredential
			}, default);

		response.Should().NotBeNull();

		await client
			.CredentialManagement
			.DeleteCredentialAsync(response.Id, default);
	}

	[Fact]
	public async Task CredentialManagementController_CreateCredentialAsync_CreateSNMPv2Credential_Succeeds()
	{
		var newSnmpCredential = new NewSnmpV2CredentialAttributes()
		{
			SnmpV2Attributes = new SnmpV2Credential()
			{
				Community = "public",
				WriteCommunity = "write"
			}
		};

		var response = await client
			.CredentialManagement
			.CreateCredentialAsync(
			new CredentialCreate<NewSnmpV2CredentialAttributes>
			{
				Name = "SNMPv2 Test Credential",
				Attributes = newSnmpCredential
			}, default);

		response.Should().NotBeNull();

		await client
			.CredentialManagement
			.DeleteCredentialAsync(response.Id, default);
	}

	[Fact]
	public async Task CredentialManagementController_CreateCredentialAsync_CreateSNMPv12Credential_Succeeds()
	{
		var newSnmpCredential = new NewSnmpV12CredentialAttributes()
		{
			SnmpV12Attributes = new SnmpV12Credential()
			{
				Community = "public",
				WriteCommunity = "write"
			}
		};

		var response = await client
			.CredentialManagement
			.CreateCredentialAsync(
			new CredentialCreate<NewSnmpV12CredentialAttributes>
			{
				Name = "SNMPv12 Test Credential",
				Attributes = newSnmpCredential
			}, default);

		response.Should().NotBeNull();

		await client
			.CredentialManagement
			.DeleteCredentialAsync(response.Id, default);
	}

	[Fact]
	public async Task CredentialManagementController_CreateCredentialAsync_CreateSNMPv3Credential_Succeeds()
	{
		var newSnmpCredential = new NewSnmpV3CredentialAttributes()
		{
			SnmpV3Attributes = new SnmpV3Credential()
			{
				Username = "test",
				AuthenticationType = CredentialAuthenticationType.None,
				AuthenticationPassword = "password",
				EncryptionType = CredentialEncryptionType.None,
				EncryptionPassword = "password"
			}
		};

		var response = await client
			.CredentialManagement
			.CreateCredentialAsync(
			new CredentialCreate<NewSnmpV3CredentialAttributes>
			{
				Name = "SNMPv12 Test Credential",
				Attributes = newSnmpCredential
			}, default);

		response.Should().NotBeNull();

		await client
			.CredentialManagement
			.DeleteCredentialAsync(response.Id, default);
	}

	[Fact]
	public async Task CredentialManagementController_CreateCredentialAsync_SshCredential_Succeeds()
	{
		var newSnmpCredential = new NewSshCredentialAttributes()
		{
			CliAccessAttributes = new CliAccessCredential()
			{
				Username = "test",
				Method = CliAccessCredentialMethod.Ssh,
				Port = "22",
				Password1 = "password",
			}
		};

		var response = await client
			.CredentialManagement
			.CreateCredentialAsync(
			new CredentialCreate<NewSshCredentialAttributes>
			{
				Name = "SNMPv12 Test Credential",
				Attributes = newSnmpCredential
			}, default);

		response.Should().NotBeNull();

		await client
			.CredentialManagement
			.DeleteCredentialAsync(response.Id, default);
	}

	[Fact]
	public async Task CredentialManagementController_CreateCredentialAsync_CliCredential_Succeeds()
	{
		var newSnmpCredential = new NewCliCredentialAttributes()
		{
			CliAccessAttributes = new CliAccessCredential()
			{
				Method = CliAccessCredentialMethod.Ssh,
				Username = "test",
				Password1 = "password",
			}
		};

		var response = await client
			.CredentialManagement
			.CreateCredentialAsync(
			new CredentialCreate<NewCliCredentialAttributes>
			{
				Name = "Cli Test Credential",
				Attributes = newSnmpCredential
			}, default);

		response.Should().NotBeNull();

		await client
			.CredentialManagement
			.DeleteCredentialAsync(response.Id, default);
	}

}
