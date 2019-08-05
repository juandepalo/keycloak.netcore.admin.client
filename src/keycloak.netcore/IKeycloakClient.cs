using Flurl.Http;

namespace Keycloak.Net
{
    public interface IKeycloakClient
    {
        IFlurlRequest GetBaseUrl(string authenticationRealm);
    }
}