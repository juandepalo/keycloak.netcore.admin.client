using System.Collections.Generic;
using System.Threading.Tasks;
using Keycloak.Net.Models.ClientInitialAccess;

namespace Keycloak.Net.ClientInitialAccess
{
    public interface IClientInitialAccess
    {
        Task<ClientInitialAccessPresentation> CreateInitialAccessTokenAsync(string realm, ClientInitialAccessCreatePresentation create);
        Task<bool> DeleteInitialAccessTokenAsync(string realm, string clientInitialAccessTokenId);
        Task<IEnumerable<ClientInitialAccessPresentation>> GetClientInitialAccessAsync(string realm);
    }
}