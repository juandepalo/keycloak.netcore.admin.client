using System.Threading.Tasks;
using Keycloak.Net.Models.Root;

namespace Keycloak.Net.Root
{
    public interface IRoot
    {
        Task<bool> CorsPreflightAsync(string realm);
        Task<ServerInfo> GetServerInfoAsync(string realm);
    }
}