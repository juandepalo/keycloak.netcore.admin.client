using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public class ClientsShould : KeycloakClientShould
    {
        [Theory]
        [InlineData("Insurance")]
        public async Task GetClientsAsync(string realm)
        {
            var result = await ClientsClient.GetClientsAsync(realm);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetClientAsync(string realm, string clientId)
        {
            var clients = await ClientsClient.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await ClientsClient.GetClientAsync(realm, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GenerateClientSecretAsync(string realm, string clientId)
        {
            var clients = await ClientsClient.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await ClientsClient.GenerateClientSecretAsync(realm, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetClientSecretAsync(string realm, string clientId)
        {
            var clients = await ClientsClient.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await ClientsClient.GetClientSecretAsync(realm, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetDefaultClientScopesAsync(string realm, string clientId)
        {
            var clients = await ClientsClient.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await ClientsClient.GetDefaultClientScopesAsync(realm, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory(Skip = "Not working yet")]
        [InlineData("Insurance", "insurance-product")]
        public async Task GenerateClientExampleAccessTokenAsync(string realm, string clientId)
        {
            var clients = await ClientsClient.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await ClientsClient.GenerateClientExampleAccessTokenAsync(realm, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetProtocolMappersInTokenGenerationAsync(string realm, string clientId)
        {
            var clients = await ClientsClient.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await ClientsClient.GetProtocolMappersInTokenGenerationAsync(realm, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetClientGrantedScopeMappingsAsync(string realm, string clientId)
        {
            var clients = await ClientsClient.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await ClientsClient.GetClientGrantedScopeMappingsAsync(realm, clientsId, realm);
                Assert.NotNull(result);
                result = await ClientsClient.GetClientGrantedScopeMappingsAsync(realm, clientsId, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetClientNotGrantedScopeMappingsAsync(string realm, string clientId)
        {
            var clients = await ClientsClient.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await ClientsClient.GetClientNotGrantedScopeMappingsAsync(realm, clientsId, realm);
                Assert.NotNull(result);
                result = await ClientsClient.GetClientNotGrantedScopeMappingsAsync(realm, clientsId, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory(Skip = "Not working yet")]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetClientProviderAsync(string realm, string clientId)
        {
            var clients = await ClientsClient.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var providerInstances = await IdentityProvidersClient.GetIdentityProviderInstancesAsync(realm);
                string providerInstanceId = providerInstances.FirstOrDefault()?.ProviderId;
                if (providerInstanceId != null)
                {
                    string result = await ClientsClient.GetClientProviderAsync(realm, clientsId, providerInstanceId);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetClientAuthorizationPermissionsInitializedAsync(string realm, string clientId)
        {
            var clients = await ClientsClient.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await ClientsClient.GetClientAuthorizationPermissionsInitializedAsync(realm, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetClientOfflineSessionCountAsync(string realm, string clientId)
        {
            var clients = await ClientsClient.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                int? result = await ClientsClient.GetClientOfflineSessionCountAsync(realm, clientsId);
                Assert.True(result >= 0);
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetClientOfflineSessionsAsync(string realm, string clientId)
        {
            var clients = await ClientsClient.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await ClientsClient.GetClientOfflineSessionsAsync(realm, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetOptionalClientScopesAsync(string realm, string clientId)
        {
            var clients = await ClientsClient.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await ClientsClient.GetOptionalClientScopesAsync(realm, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GenerateClientRegistrationAccessTokenAsync(string realm, string clientId)
        {
            var clients = await ClientsClient.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await ClientsClient.GenerateClientRegistrationAccessTokenAsync(realm, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory(Skip = "Not working yet")]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetUserForServiceAccountAsync(string realm, string clientId)
        {
            var clients = await ClientsClient.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await ClientsClient.GetUserForServiceAccountAsync(realm, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetClientSessionCountAsync(string realm, string clientId)
        {
            var clients = await ClientsClient.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                int? result = await ClientsClient.GetClientSessionCountAsync(realm, clientsId);
                Assert.True(result >= 0);
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task TestClientClusterNodesAvailableAsync(string realm, string clientId)
        {
            var clients = await ClientsClient.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await ClientsClient.TestClientClusterNodesAvailableAsync(realm, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetClientUserSessionsAsync(string realm, string clientId)
        {
            var clients = await ClientsClient.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await ClientsClient.GetClientUserSessionsAsync(realm, clientsId);
                Assert.NotNull(result);
            }
        }
    }
}
