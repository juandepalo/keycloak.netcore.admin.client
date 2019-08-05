using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using Keycloak.Net.Models.Components;

namespace Keycloak.Net.ClientRegistrationPolicy
{
    public class ClientRegistrationPolicy : KeycloakClient, IClientRegistrationPolicy
    {

        public async Task<IEnumerable<ComponentType>> GetRetrieveProvidersBasePathAsync(string realm) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/client-registration-policy/providers")
            .GetJsonAsync<IEnumerable<ComponentType>>()
            .ConfigureAwait(false);
    }
}
