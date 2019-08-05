using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public class ClientRegistrationPolicyShould : KeycloakClientShould
    {
        [Theory]
        [InlineData("Insurance")]
        public async Task GetRetrieveProvidersBasePathAsync(string realm)
        {
            var result = await ClientRegistrationPolicyClient.GetRetrieveProvidersBasePathAsync(realm);
            Assert.NotNull(result);
        }
    }
}
