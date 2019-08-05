using System.Collections.Generic;
using System.Threading.Tasks;
using Keycloak.Net.Models.ClientScopes;

namespace Keycloak.Net.ClientScopes
{
    public interface IClientScopes
    {
        Task<bool> CreateClientScopeAsync(string realm, ClientScope clientScope);
        Task<bool> DeleteClientScopeAsync(string realm, string clientScopeId);
        Task<ClientScope> GetClientScopeAsync(string realm, string clientScopeId);
        Task<IEnumerable<ClientScope>> GetClientScopesAsync(string realm);
        Task<bool> UpdateClientScopeAsync(string realm, string clientScopeId, ClientScope clientScope);
    }
}