using System.Collections.Generic;
using System.Threading.Tasks;
using Keycloak.Net.Models.Clients;
using Keycloak.Net.Models.ClientScopes;
using Keycloak.Net.Models.Common;
using Keycloak.Net.Models.Groups;
using Keycloak.Net.Models.RealmsAdmin;

namespace Keycloak.Net.RealmsAdmin
{
    public interface IRealmsAdmin
    {
        Task<Client> BasePathForImportingClientsAsync(string realm, string description);
        Task<bool> ClearKeysCacheAsync(string realm);
        Task<bool> ClearRealmCacheAsync(string realm);
        Task<bool> ClearUserCacheAsync(string realm);
        Task<bool> DeleteAdminEventsAsync(string realm);
        Task<bool> DeleteEventsAsync(string realm);
        Task<bool> DeleteRealmAsync(string realm);
        Task<bool> DeleteRealmDefaultClientScopeAsync(string realm, string clientScopeId);
        Task<bool> DeleteRealmGroupAsync(string realm, string groupId);
        Task<bool> DeleteRealmOptionalClientScopeAsync(string realm, string clientScopeId);
        Task<bool> DeleteUserSessionAsync(string realm, string session);
        Task<IEnumerable<AdminEvent>> GetAdminEventsAsync(string realm, string authClient = null, string authIpAddress = null, string authRealm = null, string authUser = null, string dateFrom = null, string dateTo = null, int? first = null, int? max = null, IEnumerable<string> operationTypes = null, string resourcePath = null, IEnumerable<string> resourceTypes = null);
        Task<IEnumerable<IDictionary<string, object>>> GetClientSessionStatsAsync(string realm);
        Task<IEnumerable<Event>> GetEventsAsync(string realm, string client = null, string dateFrom = null, string dateTo = null, int? first = null, string ipAddress = null, int? max = null, string type = null, string user = null);
        Task<Realm> GetRealmAsync(string realm);
        Task<IEnumerable<ClientScope>> GetRealmDefaultClientScopesAsync(string realm);
        Task<RealmEventsConfig> GetRealmEventsProviderConfigurationAsync(string realm);
        Task<Group> GetRealmGroupByPathAsync(string realm, string path);
        Task<IEnumerable<Group>> GetRealmGroupHierarchyAsync(string realm);
        Task<IEnumerable<ClientScope>> GetRealmOptionalClientScopesAsync(string realm);
        Task<ManagementPermission> GetRealmUsersManagementPermissionsAsync(string realm);
        Task<bool> ImportRealmAsync(string realm, Realm rep);
        Task<GlobalRequestResult> PushRealmRevocationPolicyAsync(string realm);
        Task<Realm> RealmPartialExportAsync(string realm, bool? exportClients = null, bool? exportGroupsAndRoles = null);
        Task<bool> RealmPartialImportAsync(string realm, PartialImport rep);
        Task<GlobalRequestResult> RemoveUserSessionsAsync(string realm);
        Task<bool> TestLdapConnectionAsync(string realm, string action = null, string bindCredential = null, string bindDn = null, string componentId = null, string connectionTimeout = null, string connectionUrl = null, string useTruststoreSpi = null);
        Task<bool> TestSmtpConnectionAsync(string realm, string config);
        Task<bool> UpdateRealmAsync(string realm, Realm rep);
        Task<bool> UpdateRealmDefaultClientScopeAsync(string realm, string clientScopeId);
        Task<bool> UpdateRealmEventsProviderConfigurationAsync(string realm, RealmEventsConfig rep);
        Task<bool> UpdateRealmGroupAsync(string realm, string groupId);
        Task<bool> UpdateRealmOptionalClientScopeAsync(string realm, string clientScopeId);
        Task<ManagementPermission> UpdateRealmUsersManagementPermissionsAsync(string realm, ManagementPermission managementPermission);
    }
}