using System.Collections.Generic;
using System.Threading.Tasks;
using Keycloak.Net.Models.Common;
using Keycloak.Net.Models.Roles;

namespace Keycloak.Net.RolesById
{
    public interface IRolesById
    {
        Task<bool> DeleteRoleByIdAsync(string realm, string roleId);
        Task<IEnumerable<Role>> GetClientRolesForCompositeByIdAsync(string realm, string roleId, string clientId);
        Task<IEnumerable<Role>> GetRealmRolesForCompositeByIdAsync(string realm, string roleId);
        Task<Role> GetRoleByIdAsync(string realm, string roleId);
        Task<ManagementPermission> GetRoleByIdAuthorizationPermissionsInitializedAsync(string realm, string roleId);
        Task<IEnumerable<Role>> GetRoleChildrenAsync(string realm, string roleId);
        Task<bool> MakeRoleCompositeAsync(string realm, string roleId, IEnumerable<Role> roles);
        Task<bool> RemoveRolesFromCompositeAsync(string realm, string roleId, IEnumerable<Role> roles);
        Task<ManagementPermission> SetRoleByIdAuthorizationPermissionsInitializedAsync(string realm, string roleId, ManagementPermission managementPermission);
        Task<bool> UpdateRoleByIdAsync(string realm, string roleId, Role role);
    }
}