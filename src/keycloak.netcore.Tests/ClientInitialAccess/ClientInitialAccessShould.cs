using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public class ClientInitialAccessShould : KeycloakClientShould
    {
        [Theory]
        [InlineData("Insurance")]
        public async Task GetClientInitialAccessAsync(string realm)
        {
            var result = await ClientInitialAccessClient.GetClientInitialAccessAsync(realm);
            Assert.NotNull(result);
        }
    }
}
