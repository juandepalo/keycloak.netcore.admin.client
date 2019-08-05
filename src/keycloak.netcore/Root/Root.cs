using System;
using System.Threading.Tasks;
using Flurl.Http;
using Keycloak.Net.Models.Root;

namespace Keycloak.Net.Root
{
    public class Root : KeycloakClient, IRoot
    {

        public async Task<ServerInfo> GetServerInfoAsync(string realm) => await GetBaseUrl(realm)
            .AppendPathSegment("/admin/serverinfo/")
            .GetJsonAsync<ServerInfo>()
            .ConfigureAwait(false);

        public async Task<bool> CorsPreflightAsync(string realm)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment("/admin/serverinfo/")
                .OptionsAsync()
                .ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }
    }
}
