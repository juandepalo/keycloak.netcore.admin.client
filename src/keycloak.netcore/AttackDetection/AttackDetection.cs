using System;
using System.Threading.Tasks;
using Flurl.Http;
using Keycloak.Net.Models.AttackDetection;

namespace Keycloak.Net.AttackDetection
{
    public  class AttackDetection : KeycloakClient
    {
        public AttackDetection(string url, Func<string> getToken) : base(url, getToken)
        {
        }

        public AttackDetection(string url, string userName, string password) : base(url, userName, password)
        {
        }

        public async Task<bool> ClearUserLoginFailuresAsync(string realm)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/attack-detection/brute-force/users")
                .DeleteAsync()
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> ClearUserLoginFailuresAsync(string realm, string userId)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/attack-detection/brute-force/users/{userId}")
                .DeleteAsync()
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        public async Task<UserNameStatus> GetUserNameStatusInBruteForceDetectionAsync(string realm, string userId) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/attack-detection/brute-force/users/{userId}")
            .GetJsonAsync<UserNameStatus>()
            .ConfigureAwait(false);
    }
}
