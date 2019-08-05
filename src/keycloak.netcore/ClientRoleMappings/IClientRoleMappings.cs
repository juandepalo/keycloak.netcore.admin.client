using System.Collections.Generic;
using System.Threading.Tasks;
using Keycloak.Net.Models.Roles;

namespace Keycloak.Net.ClientRoleMappings
{
    public interface IClientRoleMappings
    {
        Task<bool> AddClientRoleMappingsToGroupAsync(string realm, string groupId, string clientId, IEnumerable<Role> roles);
        Task<bool> AddClientRoleMappingsToUserAsync(string realm, string userId, string clientId, IEnumerable<Role> roles);
        Task<bool> DeleteClientRoleMappingsFromGroupAsync(string realm, string groupId, string clientId, IEnumerable<Role> roles);
        Task<bool> DeleteClientRoleMappingsFromUserAsync(string realm, string userId, string clientId, IEnumerable<Role> roles);
        Task<IEnumerable<Role>> GetAvailableClientRoleMappingsForGroupAsync(string realm, string groupId, string clientId);
        Task<IEnumerable<Role>> GetAvailableClientRoleMappingsForUserAsync(string realm, string userId, string clientId);
        Task<IEnumerable<Role>> GetClientRoleMappingsForGroupAsync(string realm, string groupId, string clientId);
        Task<IEnumerable<Role>> GetClientRoleMappingsForUserAsync(string realm, string userId, string clientId);
        Task<IEnumerable<Role>> GetEffectiveClientRoleMappingsForGroupAsync(string realm, string groupId, string clientId);
        Task<IEnumerable<Role>> GetEffectiveClientRoleMappingsForUserAsync(string realm, string userId, string clientId);
    }
}