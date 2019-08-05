using System.Threading.Tasks;
using Keycloak.Net.Models.UserStorageProvider;

namespace Keycloak.Net.UserStorageProvider
{
    public interface IUserStorageProvider
    {
        Task<bool> RemoveImportedUsersAsync(string realm, string storageProviderId);
        Task<SynchronizationResult> TriggerLdapMapperSynchronizationAsync(string realm, string storageProviderId, string mapperId, LdapMapperSyncActions direction);
        Task<SynchronizationResult> TriggerUserSynchronizationAsync(string realm, string storageProviderId, UserSyncActions action);
        Task<bool> UnlinkImportedUsersAsync(string realm, string storageProviderId);
    }
}