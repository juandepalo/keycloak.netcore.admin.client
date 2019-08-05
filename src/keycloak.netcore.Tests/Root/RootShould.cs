using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public class RootShould : KeycloakClientShould
    {
        [Theory]
        [InlineData("Insurance")]
        public async Task GetServerInfoAsync(string realm)
        {
            var result = await RootClient.GetServerInfoAsync(realm);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task CorsPreflightAsync(string realm)
        {
            bool? result = await RootClient.CorsPreflightAsync(realm);
            Assert.True(result);
        }
    }
}
