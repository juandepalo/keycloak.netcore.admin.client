using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public class KeyShould : KeycloakClientShould
    {
        [Theory]
        [InlineData("Insurance")]
        public async Task GetKeysAsync(string realm)
        {
            var result = await KeyClient.GetKeysAsync(realm);
            Assert.NotNull(result);
        }
    }
}
