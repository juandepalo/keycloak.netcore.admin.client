using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public class ComponentsShould : KeycloakClientShould
    {
        [Theory]
        [InlineData("Insurance")]
        public async Task GetComponentsAsync(string realm)
        {
            var result = await ComponentsClient.GetComponentsAsync(realm);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetComponentAsync(string realm)
        {
            var components = await ComponentsClient.GetComponentsAsync(realm);
            string componentId = components.FirstOrDefault()?.Id;
            if (componentId != null)
            {
                var result = await ComponentsClient.GetComponentAsync(realm, componentId);
                Assert.NotNull(result);
            }
        }
    }
}
