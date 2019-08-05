using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public class ClientScopesShould : KeycloakClientShould
    {
        [Theory]
        [InlineData("Insurance")]
        public async Task GetClientScopesAsync(string realm)
        {
            var result = await ClientScopesClient.GetClientScopesAsync(realm);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetClientScopeAsync(string realm)
        {
            var clientScopes = await ClientScopesClient.GetClientScopesAsync(realm);
            string clientScopeId = clientScopes.FirstOrDefault()?.Id;
            if (clientScopeId != null)
            {
                var result = await ClientScopesClient.GetClientScopeAsync(realm, clientScopeId);
                Assert.NotNull(result);
            }
        }
    }
}
