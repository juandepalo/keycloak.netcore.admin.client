using System.Collections.Generic;
using System.Threading.Tasks;
using Keycloak.Net.Models.Groups;
using Keycloak.Net.Models.Users;

namespace Keycloak.Net.Users
{
    public interface IUsers
    {
        Task<bool> AddUserSocialLoginProviderAsync(string realm, string userId, string provider, FederatedIdentity federatedIdentity);
        Task<bool> CreateUserAsync(string realm, User user);
        Task<bool> DeleteUserAsync(string realm, string userId);
        Task<bool> DeleteUserGroupAsync(string realm, string userId, string groupId);
        Task<bool> DisableUserCredentialsAsync(string realm, string userId, IEnumerable<string> credentialTypes);
        Task<User> GetUserAsync(string realm, string userId);
        Task<string> GetUserConsentsAsync(string realm, string userId);
        Task<IEnumerable<Group>> GetUserGroupsAsync(string realm, string userId);
        Task<int> GetUserGroupsCountAsync(string realm, string userId);
        Task<IEnumerable<UserSession>> GetUserOfflineSessionsAsync(string realm, string userId, string clientId);
        Task<IEnumerable<User>> GetUsersAsync(string realm, bool? briefRepresentation = null, string email = null, int? first = null, string firstName = null, string lastName = null, int? max = null, string search = null, string username = null);
        Task<int> GetUsersCountAsync(string realm);
        Task<IEnumerable<UserSession>> GetUserSessionsAsync(string realm, string userId);
        Task<IEnumerable<FederatedIdentity>> GetUserSocialLoginsAsync(string realm, string userId);
        Task<IDictionary<string, object>> ImpersonateUserAsync(string realm, string userId);
        Task<bool> RemoveUserSessionsAsync(string realm, string userId);
        Task<bool> RemoveUserSocialLoginProviderAsync(string realm, string userId, string provider);
        Task<bool> RemoveUserTotpAsync(string realm, string userId);
        Task<bool> ResetUserPasswordAsync(string realm, string userId, string password);
        Task<bool> RevokeUserConsentAndOfflineTokensAsync(string realm, string userId, string clientId);
        Task<bool> SendUserUpdateAccountEmailAsync(string realm, string userId, IEnumerable<string> requiredActions, string clientId = null, int? lifespan = null, string redirectUri = null);
        Task<bool> UpdateUserAsync(string realm, string userId, User user);
        Task<bool> UpdateUserGroupAsync(string realm, string userId, string groupId, Group group);
        Task<bool> VerifyUserEmailAddressAsync(string realm, string userId, string clientId = null, string redirectUri = null);
    }
}