using System.Collections.Generic;
using System.Threading.Tasks;
using Keycloak.Net.Models.Common;
using Keycloak.Net.Models.Roles;

namespace Keycloak.Net.RoleMapper
{
    public interface IRoleMapper
    {
        Task<bool> AddRealmRoleMappingsToGroupAsync(string realm, string groupId, IEnumerable<Role> roles);
        Task<bool> AddRealmRoleMappingsToUserAsync(string realm, string userId, IEnumerable<Role> roles);
        Task<bool> DeleteRealmRoleMappingsFromGroupAsync(string realm, string groupId, IEnumerable<Role> roles);
        Task<bool> DeleteRealmRoleMappingsFromUserAsync(string realm, string userId, IEnumerable<Role> roles);
        Task<IEnumerable<Role>> GetAvailableRealmRoleMappingsForGroupAsync(string realm, string groupId);
        Task<IEnumerable<Role>> GetAvailableRealmRoleMappingsForUserAsync(string realm, string userId);
        Task<IEnumerable<Role>> GetEffectiveRealmRoleMappingsForGroupAsync(string realm, string groupId);
        Task<IEnumerable<Role>> GetEffectiveRealmRoleMappingsForUserAsync(string realm, string userId);
        Task<IEnumerable<Role>> GetRealmRoleMappingsForGroupAsync(string realm, string groupId);
        Task<IEnumerable<Role>> GetRealmRoleMappingsForUserAsync(string realm, string userId);
        Task<Mapping> GetRoleMappingsForGroupAsync(string realm, string groupId);
        Task<Mapping> GetRoleMappingsForUserAsync(string realm, string userId);
    }
}