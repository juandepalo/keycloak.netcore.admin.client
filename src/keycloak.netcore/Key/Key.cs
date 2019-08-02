using System;
using System.Threading.Tasks;
using Flurl.Http;
using Keycloak.Net.Models.Key;

namespace Keycloak.Net.Key
{
    public class Key : KeycloakClient
    {
        public Key(string url, Func<string> getToken) : base(url, getToken)
        {
        }

        public Key(string url, string userName, string password) : base(url, userName, password)
        {
        }

        public async Task<KeysMetadata> GetKeysAsync(string realm) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/keys")
            .GetJsonAsync<KeysMetadata>()
            .ConfigureAwait(false);
    }
}
