using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public class ClientAttributeCertificateShould : KeycloakClientShould
    {
        [Theory]
        [InlineData("Insurance")]
        public async Task GetKeyInfoAsync(string realm)
        {
            var clients = await ClientsClient.GetClientsAsync(realm);
            (string clientId, string attribute) = clients
                .Where(x => x.Attributes.Any())
                .Select(client => (client.Id, client.Attributes.FirstOrDefault().Key))
                .FirstOrDefault();
            if (clientId != null)
            {
                var result = await ClientAttributeCertificateClient.GetKeyInfoAsync(realm, clientId, attribute);
                Assert.NotNull(result);
            }
        }
    }
}
