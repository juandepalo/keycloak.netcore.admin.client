using System.Collections.Generic;
using System.Threading.Tasks;
using Keycloak.Net.Models.AuthenticationManagement;

namespace Keycloak.Net.AuthenticationManagement
{
    public interface IAuthenticationManagement
    {
        Task<bool> AddAuthenticationExecutionAsync(string realm, AuthenticationExecution authenticationExecution);
        Task<bool> AddAuthenticationFlowAndExecutionToAuthenticationFlowAsync(string realm, string flowAlias, IDictionary<string, object> dataWithAliasTypeProviderDescription);
        Task<bool> AddAuthenticationFlowExecutionAsync(string realm, string flowAlias, IDictionary<string, object> dataWithProvider);
        Task<bool> CreateAuthenticationFlowAsync(string realm, AuthenticationFlow authenticationFlow);
        Task<bool> DeleteAuthenticationExecutionAsync(string realm, string executionId);
        Task<bool> DeleteAuthenticationFlowAsync(string realm, string flowId);
        Task<bool> DeleteAuthenticatorConfigurationAsync(string realm, string configurationId);
        Task<bool> DeleteRequiredActionAsync(string realm, string requiredActionAlias);
        Task<bool> DuplicateAuthenticationFlowAsync(string realm, string flowAlias, string newName);
        Task<AuthenticationExecutionById> GetAuthenticationExecutionAsync(string realm, string executionId);
        Task<AuthenticationFlow> GetAuthenticationFlowByIdAsync(string realm, string flowId);
        Task<IEnumerable<AuthenticationFlowExecution>> GetAuthenticationFlowExecutionsAsync(string realm, string flowAlias);
        Task<IEnumerable<AuthenticationFlow>> GetAuthenticationFlowsAsync(string realm);
        Task<AuthenticatorConfig> GetAuthenticatorConfigurationAsync(string realm, string configurationId);
        Task<AuthenticatorConfigInfo> GetAuthenticatorProviderConfigurationDescriptionAsync(string realm, string providerId);
        Task<IEnumerable<IDictionary<string, object>>> GetAuthenticatorProvidersAsync(string realm);
        Task<IEnumerable<IDictionary<string, object>>> GetClientAuthenticatorProvidersAsync(string realm);
        Task<IDictionary<string, object>> GetConfigurationDescriptionsForAllClientsAsync(string realm);
        Task<IEnumerable<IDictionary<string, object>>> GetFormActionProvidersAsync(string realm);
        Task<IEnumerable<IDictionary<string, object>>> GetFormProvidersAsync(string realm);
        Task<RequiredActionProvider> GetRequiredActionByAliasAsync(string realm, string requiredActionAlias);
        Task<IEnumerable<RequiredActionProvider>> GetRequiredActionsAsync(string realm);
        Task<IEnumerable<IDictionary<string, object>>> GetUnregisteredRequiredActionsAsync(string realm);
        Task<bool> LowerAuthenticationExecutionPriorityAsync(string realm, string executionId);
        Task<bool> LowerRequiredActionPriorityAsync(string realm, string requiredActionAlias);
        Task<bool> RaiseAuthenticationExecutionPriorityAsync(string realm, string executionId);
        Task<bool> RaiseRequiredActionPriorityAsync(string realm, string requiredActionAlias);
        Task<bool> RegisterRequiredActionAsync(string realm, IDictionary<string, object> dataWithProviderIdName);
        Task<bool> UpdateAuthenticationExecutionConfigurationAsync(string realm, string executionId, AuthenticatorConfig authenticatorConfig);
        Task<bool> UpdateAuthenticationFlowAsync(string realm, string flowId, AuthenticationFlow authenticationFlow);
        Task<bool> UpdateAuthenticationFlowExecutionsAsync(string realm, string flowAlias, AuthenticationExecutionInfo authenticationExecutionInfo);
        Task<bool> UpdateAuthenticatorConfigurationAsync(string realm, string configurationId, AuthenticatorConfig authenticatorConfig);
        Task<bool> UpdateRequiredActionAsync(string realm, string requiredActionAlias, RequiredActionProvider requiredActionProvider);
    }
}