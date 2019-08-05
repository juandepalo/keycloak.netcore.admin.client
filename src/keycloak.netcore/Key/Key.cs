using System;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using Keycloak.Net.Models.Key;

namespace Keycloak.Net.Key
{
    public class Key : KeycloakClient, IKey
    {

        public async Task<KeysMetadata> GetKeysAsync(string realm) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/keys")
            .GetJsonAsync<KeysMetadata>()
            .ConfigureAwait(false);
    }
}
