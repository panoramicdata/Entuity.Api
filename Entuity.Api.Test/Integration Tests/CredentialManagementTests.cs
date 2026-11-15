using Entuity.Api.Enums;
using Entuity.Api.Interfaces;
using Entuity.Api.Models.CredentialManagementData.CredentialTypes;
using Entuity.Api.Models.CredentialManagementData.Post;
using Entuity.Api.Models.CredentialManagementData.Post.CredentialAttributeSets;
using Entuity.Api.Models.CredentialManagementData.Update;
using AwesomeAssertions;

namespace Entuity.Api.Test.Integration_Tests;
public class CredentialManagementTests(EntuityClient client) : TestFixture
{
	[Fact]
	public async Task CredentialManagementController_GetAllCredentialsAsync_ReturnsCredentials()
	{
		var response = await client.CredentialManagement.GetAllCredentialsAsync(default);

		response.Should().NotBeNull();
	}

	[Fact]
	public async Task CredentialManagementController_CreateCredentialAsync_CreateSNMPv1Credential_Succeeds()
	{
		var id = await CreateCredentialAsync("SNMPv1 Test Credential", new SnmpV1CredentialAttributes
		{
			SnmpV1Attributes = new SnmpV1Credential { Community = "public", WriteCommunity = "write" }
		});

		await client.CredentialManagement.DeleteCredentialAsync(id, default);
	}

	[Fact]
	public async Task CredentialManagementController_CreateCredentialAsync_CreateSNMPv2Credential_Succeeds()
	{
		var id = await CreateCredentialAsync("SNMPv2 Test Credential", new SnmpV2CredentialAttributes
		{
			SnmpV2Attributes = new SnmpV2Credential { Community = "public", WriteCommunity = "write" }
		});

		await client.CredentialManagement.DeleteCredentialAsync(id, default);
	}

	[Fact]
	public async Task CredentialManagementController_CreateCredentialAsync_CreateSNMPv12Credential_Succeeds()
	{
		var id = await CreateCredentialAsync("SNMPv12 Test Credential", new SnmpV12CredentialAttributes
		{
			SnmpV12Attributes = new SnmpV12Credential { Community = "public", WriteCommunity = "write" }
		});

		await client.CredentialManagement.DeleteCredentialAsync(id, default);
	}

	[Fact]
	public async Task CredentialManagementController_CreateCredentialAsync_CreateSNMPv3Credential_Succeeds()
	{
		var id = await CreateCredentialAsync("SNMPv12 Test Credential", new SnmpV3CredentialAttributes
		{
			SnmpV3Attributes = new SnmpV3Credential
			{
				Username = "test",
				AuthenticationType = CredentialAuthenticationType.None,
				AuthenticationPassword = "password",
				EncryptionType = CredentialEncryptionType.None,
				EncryptionPassword = "password"
			}
		});

		await client.CredentialManagement.DeleteCredentialAsync(id, default);
	}

	[Fact]
	public async Task CredentialManagementController_CreateCredentialAsync_SshCredential_Succeeds()
	{
		var id = await CreateCredentialAsync("SNMPv12 Test Credential", new SshCredentialAttributes
		{
			CliAccessAttributes = new CliAccessCredential
			{
				Username = "test",
				Method = CliAccessCredentialMethod.Ssh,
				Port = "22",
				Password1 = "password",
			}
		});

		await client.CredentialManagement.DeleteCredentialAsync(id, default);
	}

	[Fact]
	public async Task CredentialManagementController_CreateCredentialAsync_CliCredential_Succeeds()
	{
		var id = await CreateCliCredentialAsync("Cli Test Credential", "test", "password");

		await client.CredentialManagement.DeleteCredentialAsync(id, default);
	}

	[Fact]
	public async Task CredentialManagementController_DeleteCredentialAsync_Succeeds()
	{
		var id = await CreateCliCredentialAsync("Cli Test Credential 2", "testusername", "passwordtest");

		(await client.CredentialManagement.DeleteCredentialAsync(id, default)).Should().NotBeNull();
	}

	[Fact]
	public async Task CredentialManagementController_UpdateCredentialAsync_Succeeds()
	{
		var id = await CreateCliCredentialAsync("Cli Test Credential 2", "testusername", "passwordtest");

		var updateCredential = new CredentialUpdate<NewCliCredentialAttributes> { Name = "Updated Credential" };

		(await client.CredentialManagement.UpdateCredentialAsync(id, updateCredential, default)).Should().NotBeNull();

		(await client.CredentialManagement.DeleteCredentialAsync(id, default)).Should().NotBeNull();
	}

	private Task<int> CreateCliCredentialAsync(string name, string username, string password)
		=> CreateCredentialAsync(name, new NewCliCredentialAttributes
		{
			CliAccessAttributes = new CliAccessCredential
			{
				Method = CliAccessCredentialMethod.Ssh,
				Username = username,
				Password1 = password,
			}
		});

	private async Task<int> CreateCredentialAsync<TAttributes>(string name, TAttributes attributes)
		where TAttributes : ICredentialAttributeSet
	{
		var response = await client.CredentialManagement.CreateCredentialAsync(
			new CredentialCreate<TAttributes> { Name = name, Attributes = attributes },
			default);

		response.Should().NotBeNull();

		return response.Id;
	}
}
