using System.Collections.Generic;
using System.Threading.Tasks;
using Keycloak.Net.Models.Clients;
using Keycloak.Net.Models.ClientScopes;
using Keycloak.Net.Models.Common;
using Keycloak.Net.Models.Roles;
using Keycloak.Net.Models.Root;
using Keycloak.Net.Models.Users;

namespace Keycloak.Net.Clients
{
    public interface IClients
    {
        Task<bool> CreateClientAsync(string realm, Client client);
        Task<bool> DeleteClientAsync(string realm, string clientId);
        Task<bool> DeleteDefaultClientScopeAsync(string realm, string clientId, string clientScopeId);
        Task<bool> DeleteOptionalClientScopeAsync(string realm, string clientId, string clientScopeId);
        Task<AccessToken> GenerateClientExampleAccessTokenAsync(string realm, string clientId, string scope = null, string userId = null);
        Task<Client> GenerateClientRegistrationAccessTokenAsync(string realm, string clientId);
        Task<Credential> GenerateClientSecretAsync(string realm, string clientId);
        Task<Client> GetClientAsync(string realm, string clientId);
        Task<ManagementPermission> GetClientAuthorizationPermissionsInitializedAsync(string realm, string clientId);
        Task<IEnumerable<Role>> GetClientGrantedScopeMappingsAsync(string realm, string clientId, string roleContainerId, string scope = null);
        Task<IEnumerable<Role>> GetClientNotGrantedScopeMappingsAsync(string realm, string clientId, string roleContainerId, string scope = null);
        Task<int> GetClientOfflineSessionCountAsync(string realm, string clientId);
        Task<IEnumerable<UserSession>> GetClientOfflineSessionsAsync(string realm, string clientId, int? first = null, int? max = null);
        Task<string> GetClientProviderAsync(string realm, string clientId, string providerId);
        Task<IEnumerable<Client>> GetClientsAsync(string realm, string clientId = null, bool? viewableOnly = null);
        Task<Credential> GetClientSecretAsync(string realm, string clientId);
        Task<int> GetClientSessionCountAsync(string realm, string clientId);
        Task<IEnumerable<UserSession>> GetClientUserSessionsAsync(string realm, string clientId, int? first = null, int? max = null);
        Task<IEnumerable<ClientScope>> GetDefaultClientScopesAsync(string realm, string clientId);
        Task<IEnumerable<ClientScope>> GetOptionalClientScopesAsync(string realm, string clientId);
        Task<IEnumerable<ClientScopeEvaluateResourceProtocolMapperEvaluation>> GetProtocolMappersInTokenGenerationAsync(string realm, string clientId, string scope = null);
        Task<User> GetUserForServiceAccountAsync(string realm, string clientId);
        Task<GlobalRequestResult> PushClientRevocationPolicyAsync(string realm, string clientId);
        Task<bool> RegisterClientClusterNodeAsync(string realm, string clientId, IDictionary<string, object> formParams);
        Task<ManagementPermission> SetClientAuthorizationPermissionsInitializedAsync(string realm, string clientId, ManagementPermission managementPermission);
        Task<GlobalRequestResult> TestClientClusterNodesAvailableAsync(string realm, string clientId);
        Task<bool> UnregisterClientClusterNodeAsync(string realm, string clientId);
        Task<bool> UpdateClientAsync(string realm, string clientId, Client client);
        Task<bool> UpdateDefaultClientScopeAsync(string realm, string clientId, string clientScopeId);
        Task<bool> UpdateOptionalClientScopeAsync(string realm, string clientId, string clientScopeId);
    }
}