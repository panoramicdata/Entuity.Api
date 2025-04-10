using Entuity.Api.Enums;
using Entuity.Api.Models.CredentialManagementData.CredentialTypes;
using Entuity.Api.Models.CredentialManagementData.Post;
using Entuity.Api.Models.CredentialManagementData.Post.CredentialAttributeSets;
using Entuity.Api.Models.CredentialManagementData.Update;
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
		var newSnmpCredential = new SnmpV1CredentialAttributes()
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
			new CredentialCreate<SnmpV1CredentialAttributes>
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
		var newSnmpCredential = new SnmpV2CredentialAttributes()
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
			new CredentialCreate<SnmpV2CredentialAttributes>
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
		var newSnmpCredential = new SnmpV12CredentialAttributes()
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
			new CredentialCreate<SnmpV12CredentialAttributes>
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
		var newSnmpCredential = new SnmpV3CredentialAttributes()
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
			new CredentialCreate<SnmpV3CredentialAttributes>
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
		var newSnmpCredential = new SshCredentialAttributes()
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
			new CredentialCreate<SshCredentialAttributes>
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

	[Fact]
	public async Task CredentialManagementController_DeleteCredentialAsync_Succeeds()
	{
		var newSnmpCredential = new NewCliCredentialAttributes()
		{
			CliAccessAttributes = new CliAccessCredential()
			{
				Method = CliAccessCredentialMethod.Ssh,
				Username = "testusername",
				Password1 = "passwordtest",
			}
		};

		var response = await client
			.CredentialManagement
			.CreateCredentialAsync(
			new CredentialCreate<NewCliCredentialAttributes>
			{
				Name = "Cli Test Credential 2",
				Attributes = newSnmpCredential
			}, default);

		response.Should().NotBeNull();

		var deleteResponse = await client
			.CredentialManagement
			.DeleteCredentialAsync(response.Id, default);

		deleteResponse.Should().NotBeNull();
	}

	[Fact]
	public async Task CredentialManagementController_UpdateCredentialAsync_Succeeds()
	{
		var newSnmpCredential = new NewCliCredentialAttributes()
		{
			CliAccessAttributes = new CliAccessCredential()
			{
				Method = CliAccessCredentialMethod.Ssh,
				Username = "testusername",
				Password1 = "passwordtest",
			}
		};

		var response = await client
			.CredentialManagement
			.CreateCredentialAsync(
			new CredentialCreate<NewCliCredentialAttributes>
			{
				Name = "Cli Test Credential 2",
				Attributes = newSnmpCredential
			}, default);

		// Update
		var updateCredential = new CredentialUpdate<NewCliCredentialAttributes>
		{
			Name = "Updated Credential",
		};

		var updateResponse = await client
			.CredentialManagement
			.UpdateCredentialAsync(response.Id, updateCredential, default);

		updateResponse.Should().NotBeNull();

		response.Should().NotBeNull();

		var deleteResponse = await client
			.CredentialManagement
			.DeleteCredentialAsync(response.Id, default);

		deleteResponse.Should().NotBeNull();
	}
}
