using System.Collections.Generic;
using System.Threading.Tasks;
using Keycloak.Net.Models.Common;
using Keycloak.Net.Models.Groups;
using Keycloak.Net.Models.Roles;
using Keycloak.Net.Models.Users;

namespace Keycloak.Net.Roles
{
    public interface IRoles
    {
        Task<bool> AddCompositesToRoleAsync(string realm, string roleName, IEnumerable<Role> roles);
        Task<bool> AddCompositesToRoleAsync(string realm, string clientId, string roleName, IEnumerable<Role> roles);
        Task<bool> CreateRoleAsync(string realm, Role role);
        Task<bool> CreateRoleAsync(string realm, string clientId, Role role);
        Task<bool> DeleteRoleByNameAsync(string realm, string roleName);
        Task<bool> DeleteRoleByNameAsync(string realm, string clientId, string roleName);
        Task<IEnumerable<Role>> GetApplicationRolesForCompositeAsync(string realm, string roleName, string forClientId);
        Task<IEnumerable<Role>> GetApplicationRolesForCompositeAsync(string realm, string clientId, string roleName, string forClientId);
        Task<IEnumerable<Group>> GetGroupsWithRoleNameAsync(string realm, string roleName, int? first = null, bool? full = null, int? max = null);
        Task<IEnumerable<Group>> GetGroupsWithRoleNameAsync(string realm, string clientId, string roleName, int? first = null, bool? full = null, int? max = null);
        Task<IEnumerable<Role>> GetRealmRolesForCompositeAsync(string realm, string roleName);
        Task<IEnumerable<Role>> GetRealmRolesForCompositeAsync(string realm, string clientId, string roleName);
        Task<ManagementPermission> GetRoleAuthorizationPermissionsInitializedAsync(string realm, string roleName);
        Task<ManagementPermission> GetRoleAuthorizationPermissionsInitializedAsync(string realm, string clientId, string roleName);
        Task<Role> GetRoleByNameAsync(string realm, string roleName);
        Task<Role> GetRoleByNameAsync(string realm, string clientId, string roleName);
        Task<IEnumerable<Role>> GetRoleCompositesAsync(string realm, string roleName);
        Task<IEnumerable<Role>> GetRoleCompositesAsync(string realm, string clientId, string roleName);
        Task<IEnumerable<Role>> GetRolesAsync(string realm);
        Task<IEnumerable<Role>> GetRolesAsync(string realm, string clientId);
        Task<IEnumerable<User>> GetUsersWithRoleNameAsync(string realm, string roleName, int? first = null, int? max = null);
        Task<IEnumerable<User>> GetUsersWithRoleNameAsync(string realm, string clientId, string roleName, int? first = null, int? max = null);
        Task<bool> RemoveCompositesFromRoleAsync(string realm, string roleName, IEnumerable<Role> roles);
        Task<bool> RemoveCompositesFromRoleAsync(string realm, string clientId, string roleName, IEnumerable<Role> roles);
        Task<ManagementPermission> SetRoleAuthorizationPermissionsInitializedAsync(string realm, string roleName, ManagementPermission managementPermission);
        Task<ManagementPermission> SetRoleAuthorizationPermissionsInitializedAsync(string realm, string clientId, string roleName, ManagementPermission managementPermission);
        Task<bool> UpdateRoleByNameAsync(string realm, string roleName, Role role);
        Task<bool> UpdateRoleByNameAsync(string realm, string clientId, string roleName, Role role);
    }
}