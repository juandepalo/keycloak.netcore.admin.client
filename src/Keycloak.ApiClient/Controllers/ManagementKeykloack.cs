using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Keycloak.ApiClient.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ManagementKeykloackController : ControllerBase
    {

        public async Task GetKeyInfoAsync(string realm)
        {
            // var clients = await _client.GetClientsAsync(realm);
            // (string clientId, string attribute) = clients
            //     .Where(x => x.Attributes.Any())
            //     .Select(client => (client.Id, client.Attributes.FirstOrDefault().Key))
            //     .FirstOrDefault();
            // if (clientId != null)
            // {
            //     var result = await _client.GetKeyInfoAsync(realm, clientId, attribute);
            //     Assert.NotNull(result);
            // }
        }



    }
}