using System.Collections.Generic;
using System.Threading.Tasks;
using Keycloak.Net.Models.Common;
using Keycloak.Net.Models.IdentityProviders;

namespace Keycloak.Net.IdentityProviders
{
    public interface IIdentityProviders
    {
        Task<bool> AddIdentityProviderMapperAsync(string realm, string identityProviderAlias, IdentityProviderMapper identityProviderMapper);
        Task<bool> CreateIdentityProviderAsync(string realm, IdentityProvider identityProvider);
        Task<bool> DeleteIdentityProviderAsync(string realm, string identityProviderAlias);
        Task<bool> DeleteIdentityProviderMapperAsync(string realm, string identityProviderAlias, string mapperId);
        Task<bool> ExportIdentityProviderPublicBrokerConfigurationAsync(string realm, string identityProviderAlias);
        Task<IdentityProvider> GetIdentityProviderAsync(string realm, string identityProviderAlias);
        Task<ManagementPermission> GetIdentityProviderAuthorizationPermissionsInitializedAsync(string realm, string identityProviderAlias);
        Task<IdentityProviderInfo> GetIdentityProviderByProviderIdAsync(string realm, string providerId);
        Task<IEnumerable<IdentityProvider>> GetIdentityProviderInstancesAsync(string realm);
        Task<IdentityProviderMapper> GetIdentityProviderMapperByIdAsync(string realm, string identityProviderAlias, string mapperId);
        Task<IEnumerable<IdentityProviderMapper>> GetIdentityProviderMappersAsync(string realm, string identityProviderAlias);
        Task<IDictionary<string, object>> GetIdentityProviderMapperTypesAsync(string realm, string identityProviderAlias);
        Task<IDictionary<string, object>> ImportIdentityProviderAsync(string realm, string input);
        Task<ManagementPermission> SetIdentityProviderAuthorizationPermissionsInitializedAsync(string realm, string identityProviderAlias, ManagementPermission managementPermission);
        Task<bool> UpdateIdentityProviderAsync(string realm, string identityProviderAlias, IdentityProvider identityProvider);
        Task<bool> UpdateIdentityProviderMapperAsync(string realm, string identityProviderAlias, string mapperId, IdentityProviderMapper identityProviderMapper);
    }
}