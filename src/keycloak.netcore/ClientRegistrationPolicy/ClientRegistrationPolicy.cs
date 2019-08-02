using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl.Http;
using Keycloak.Net.Models.Components;

namespace Keycloak.Net.ClientRegistrationPolicy
{
    public class ClientRegistrationPolicy : KeycloakClient
    {
        public ClientRegistrationPolicy(string url, Func<string> getToken) : base(url, getToken)
        {
        }

        public ClientRegistrationPolicy(string url, string userName, string password) : base(url, userName, password)
        {
        }

        public async Task<IEnumerable<ComponentType>> GetRetrieveProvidersBasePathAsync(string realm) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/client-registration-policy/providers")
            .GetJsonAsync<IEnumerable<ComponentType>>()
            .ConfigureAwait(false);
    }
}
