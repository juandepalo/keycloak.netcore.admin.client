using System.Collections.Generic;
using System.Threading.Tasks;
using Keycloak.Net.Models.Components;

namespace Keycloak.Net.ClientRegistrationPolicy
{
    public interface IClientRegistrationPolicy
    {
        Task<IEnumerable<ComponentType>> GetRetrieveProvidersBasePathAsync(string realm);
    }
}