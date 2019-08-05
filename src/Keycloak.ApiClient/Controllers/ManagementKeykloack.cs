using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Keycloak.Authentication.Clients;
using Keycloak.Net.AttackDetection;

namespace Keycloak.ApiClient.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ManagementKeykloackController : ControllerBase
    {
        public IAttackDetection AttackDetection { get; set; }

        public ManagementKeykloackController(IAttackDetection attackDetection)
        {
            AttackDetection = attackDetection;
        }
        [Authorize(Policy = "administrador")]
        public async Task<bool> ClearUserLoginFailuresAsync(string realm)
        {
            return await AttackDetection.ClearUserLoginFailuresAsync(realm);
        }



    }
}