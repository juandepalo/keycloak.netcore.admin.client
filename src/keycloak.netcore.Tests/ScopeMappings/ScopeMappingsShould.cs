using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public class ScopeMappingsShould : KeycloakClientShould
    {
        [Theory]
        [InlineData("Insurance")]
        public async Task GetScopeMappingsAsync(string realm)
        {
            var clientScopes = await ClientScopesClient.GetClientScopesAsync(realm);
            string clientScopeId = clientScopes.FirstOrDefault()?.Id;
            if (clientScopeId != null)
            {
                var result = await ScopeMappingsClient.GetScopeMappingsAsync(realm, clientScopeId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetClientRolesForClientScopeAsync(string realm)
        {
            var clientScopes = await ClientScopesClient.GetClientScopesAsync(realm);
            string clientScopeId = clientScopes.FirstOrDefault()?.Id;
            if (clientScopeId != null)
            {
                var clients = await ClientsClient.GetClientsAsync(realm);
                string clientId = clients.FirstOrDefault()?.Id;
                if (clientId != null)
                {
                    var result = await ScopeMappingsClient.GetClientRolesForClientScopeAsync(realm, clientScopeId, clientId);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetAvailableClientRolesForClientScopeAsync(string realm)
        {
            var clientScopes = await ClientScopesClient.GetClientScopesAsync(realm);
            string clientScopeId = clientScopes.FirstOrDefault()?.Id;
            if (clientScopeId != null)
            {
                var clients = await ClientsClient.GetClientsAsync(realm);
                string clientId = clients.FirstOrDefault()?.Id;
                if (clientId != null)
                {
                    var result = await ScopeMappingsClient.GetAvailableClientRolesForClientScopeAsync(realm, clientScopeId, clientId);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetEffectiveClientRolesForClientScopeAsync(string realm)
        {
            var clientScopes = await ClientScopesClient.GetClientScopesAsync(realm);
            string clientScopeId = clientScopes.FirstOrDefault()?.Id;
            if (clientScopeId != null)
            {
                var clients = await ClientsClient.GetClientsAsync(realm);
                string clientId = clients.FirstOrDefault()?.Id;
                if (clientId != null)
                {
                    var result = await ScopeMappingsClient.GetEffectiveClientRolesForClientScopeAsync(realm, clientScopeId, clientId);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetRealmRolesForClientScopeAsync(string realm)
        {
            var clientScopes = await ClientScopesClient.GetClientScopesAsync(realm);
            string clientScopeId = clientScopes.FirstOrDefault()?.Id;
            if (clientScopeId != null)
            {
                var result = await ScopeMappingsClient.GetRealmRolesForClientScopeAsync(realm, clientScopeId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetAvailableRealmRolesForClientScopeAsync(string realm)
        {
            var clientScopes = await ClientScopesClient.GetClientScopesAsync(realm);
            string clientScopeId = clientScopes.FirstOrDefault()?.Id;
            if (clientScopeId != null)
            {
                var result = await ScopeMappingsClient.GetAvailableRealmRolesForClientScopeAsync(realm, clientScopeId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetEffectiveRealmRolesForClientScopeAsync(string realm)
        {
            var clientScopes = await ClientScopesClient.GetClientScopesAsync(realm);
            string clientScopeId = clientScopes.FirstOrDefault()?.Id;
            if (clientScopeId != null)
            {
                var result = await ScopeMappingsClient.GetEffectiveRealmRolesForClientScopeAsync(realm, clientScopeId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetScopeMappingsForClientAsync(string realm)
        {
            var clients = await ClientsClient.GetClientsAsync(realm);
            string clientId = clients.FirstOrDefault()?.Id;
            if (clientId != null)
            {
                var result = await ScopeMappingsClient.GetScopeMappingsForClientAsync(realm, clientId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetClientRolesScopeMappingsForClientAsync(string realm)
        {
            var clients = await ClientsClient.GetClientsAsync(realm);
            string clientId = clients.FirstOrDefault()?.Id;
            if (clientId != null)
            {
                var result = await ScopeMappingsClient.GetClientRolesScopeMappingsForClientAsync(realm, clientId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetAvailableClientRolesForClientScopeForClientAsync(string realm)
        {
            var clientScopes = await ClientScopesClient.GetClientScopesAsync(realm);
            string clientScopeId = clientScopes.FirstOrDefault()?.Id;
            if (clientScopeId != null)
            {
                var clients = await ClientsClient.GetClientsAsync(realm);
                string clientId = clients.FirstOrDefault()?.Id;
                if (clientId != null)
                {
                    var result = await ScopeMappingsClient.GetAvailableClientRolesForClientScopeForClientAsync(realm, clientScopeId, clientId);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetEffectiveClientRolesForClientScopeForClientAsync(string realm)
        {
            var clientScopes = await ClientScopesClient.GetClientScopesAsync(realm);
            string clientScopeId = clientScopes.FirstOrDefault()?.Id;
            if (clientScopeId != null)
            {
                var clients = await ClientsClient.GetClientsAsync(realm);
                string clientId = clients.FirstOrDefault()?.Id;
                if (clientId != null)
                {
                    var result = await ScopeMappingsClient.GetEffectiveClientRolesForClientScopeForClientAsync(realm, clientScopeId, clientId);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetRealmRolesScopeMappingsForClientAsync(string realm)
        {
            var clients = await ClientsClient.GetClientsAsync(realm);
            string clientId = clients.FirstOrDefault()?.Id;
            if (clientId != null)
            {
                var result = await ScopeMappingsClient.GetRealmRolesScopeMappingsForClientAsync(realm, clientId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetAvailableRealmRolesForClientScopeForClientAsync(string realm)
        {
            var clients = await ClientsClient.GetClientsAsync(realm);
            string clientId = clients.FirstOrDefault()?.Id;
            if (clientId != null)
            {
                var result = await ScopeMappingsClient.GetAvailableRealmRolesForClientScopeForClientAsync(realm, clientId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetEffectiveRealmRolesForClientScopeForClientAsync(string realm)
        {
            var clients = await ClientsClient.GetClientsAsync(realm);
            string clientId = clients.FirstOrDefault()?.Id;
            if (clientId != null)
            {
                var result = await ScopeMappingsClient.GetEffectiveRealmRolesForClientScopeForClientAsync(realm, clientId);
                Assert.NotNull(result);
            }
        }
    }
}
