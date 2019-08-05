using System.Collections.Generic;
using System.Threading.Tasks;
using Keycloak.Net.Models.Common;
using Keycloak.Net.Models.Roles;

namespace Keycloak.Net.ScopeMappings
{
    public interface IScopeMappings
    {
        Task<bool> AddClientRolesScopeMappingToClientAsync(string realm, string clientId, IEnumerable<Role> roles);
        Task<bool> AddClientRolesToClientScopeAsync(string realm, string clientScopeId, string clientId, IEnumerable<Role> roles);
        Task<bool> AddRealmRolesScopeMappingToClientAsync(string realm, string clientId, IEnumerable<Role> roles);
        Task<bool> AddRealmRolesToClientScopeAsync(string realm, string clientScopeId, IEnumerable<Role> roles);
        Task<IEnumerable<Role>> GetAvailableClientRolesForClientScopeAsync(string realm, string clientScopeId, string clientId);
        Task<IEnumerable<Role>> GetAvailableClientRolesForClientScopeForClientAsync(string realm, string clientScopeId, string clientId);
        Task<IEnumerable<Role>> GetAvailableRealmRolesForClientScopeAsync(string realm, string clientScopeId);
        Task<IEnumerable<Role>> GetAvailableRealmRolesForClientScopeForClientAsync(string realm, string clientId);
        Task<IEnumerable<Role>> GetClientRolesForClientScopeAsync(string realm, string clientScopeId, string clientId);
        Task<IEnumerable<Role>> GetClientRolesScopeMappingsForClientAsync(string realm, string clientId);
        Task<IEnumerable<Role>> GetEffectiveClientRolesForClientScopeAsync(string realm, string clientScopeId, string clientId);
        Task<IEnumerable<Role>> GetEffectiveClientRolesForClientScopeForClientAsync(string realm, string clientScopeId, string clientId);
        Task<IEnumerable<Role>> GetEffectiveRealmRolesForClientScopeAsync(string realm, string clientScopeId);
        Task<IEnumerable<Role>> GetEffectiveRealmRolesForClientScopeForClientAsync(string realm, string clientId);
        Task<IEnumerable<Role>> GetRealmRolesForClientScopeAsync(string realm, string clientScopeId);
        Task<IEnumerable<Role>> GetRealmRolesScopeMappingsForClientAsync(string realm, string clientId);
        Task<Mapping> GetScopeMappingsAsync(string realm, string clientScopeId);
        Task<Mapping> GetScopeMappingsForClientAsync(string realm, string clientId);
        Task<bool> RemoveClientRolesFromClientScopeAsync(string realm, string clientScopeId, string clientId, IEnumerable<Role> roles);
        Task<bool> RemoveClientRolesFromClientScopeForClientAsync(string realm, string clientId, IEnumerable<Role> roles);
        Task<bool> RemoveRealmRolesFromClientScopeAsync(string realm, string clientScopeId, IEnumerable<Role> roles);
        Task<bool> RemoveRealmRolesFromClientScopeForClientAsync(string realm, string clientId, IEnumerable<Role> roles);
    }
}