using System.Collections.Generic;
using System.Threading.Tasks;
using Keycloak.Net.Models.Common;
using Keycloak.Net.Models.Groups;
using Keycloak.Net.Models.Users;

namespace Keycloak.Net.Groups
{
    public interface IGroups
    {
        Task<bool> CreateGroupAsync(string realm, Group group);
        Task<bool> DeleteGroupAsync(string realm, string groupId);
        Task<Group> GetGroupAsync(string realm, string groupId);
        Task<ManagementPermission> GetGroupClientAuthorizationPermissionsInitializedAsync(string realm, string groupId);
        Task<IEnumerable<Group>> GetGroupHierarchyAsync(string realm, int? first = null, int? max = null, string search = null);
        Task<int> GetGroupsCountAsync(string realm, string search = null, bool? top = null);
        Task<IEnumerable<User>> GetGroupUsersAsync(string realm, string groupId);
        Task<ManagementPermission> SetGroupClientAuthorizationPermissionsInitializedAsync(string realm, string groupId, ManagementPermission managementPermission);
        Task<bool> SetOrCreateGroupChildAsync(string realm, string groupId, Group group);
        Task<bool> UpdateGroupAsync(string realm, string groupId, Group group);
    }
}