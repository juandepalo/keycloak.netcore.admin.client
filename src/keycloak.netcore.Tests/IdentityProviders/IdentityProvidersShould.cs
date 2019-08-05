using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public class IdentityProvidersShould : KeycloakClientShould
    {
        [Theory]
        [InlineData("Insurance")]
        public async Task GetIdentityProviderInstancesAsync(string realm)
        {
            var result = await IdentityProvidersClient.GetIdentityProviderInstancesAsync(realm);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetIdentityProviderAsync(string realm)
        {
            var identityProviderInstances = await IdentityProvidersClient.GetIdentityProviderInstancesAsync(realm);
            string identityProviderAlias = identityProviderInstances.FirstOrDefault()?.Alias;
            if (identityProviderAlias != null)
            {
                var result = await IdentityProvidersClient.GetIdentityProviderAsync(realm, identityProviderAlias);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetIdentityProviderAuthorizationPermissionsInitializedAsync(string realm)
        {
            var identityProviderInstances = await IdentityProvidersClient.GetIdentityProviderInstancesAsync(realm);
            string identityProviderAlias = identityProviderInstances.FirstOrDefault()?.Alias;
            if (identityProviderAlias != null)
            {
                var result = await IdentityProvidersClient.GetIdentityProviderAuthorizationPermissionsInitializedAsync(realm, identityProviderAlias);
                Assert.NotNull(result);
            }
        }

        [Theory(Skip = "500 Internal server error")]
        [InlineData("Insurance")]
        public async Task GetIdentityProviderMapperTypesAsync(string realm)
        {
            var identityProviderInstances = await IdentityProvidersClient.GetIdentityProviderInstancesAsync(realm);
            string identityProviderAlias = identityProviderInstances.FirstOrDefault()?.Alias;
            if (identityProviderAlias != null)
            {
                var result = await IdentityProvidersClient.GetIdentityProviderMapperTypesAsync(realm, identityProviderAlias);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetIdentityProviderMappersAsync(string realm)
        {
            var identityProviderInstances = await IdentityProvidersClient.GetIdentityProviderInstancesAsync(realm);
            string identityProviderAlias = identityProviderInstances.FirstOrDefault()?.Alias;
            if (identityProviderAlias != null)
            {
                var result = await IdentityProvidersClient.GetIdentityProviderMappersAsync(realm, identityProviderAlias);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetIdentityProviderMapperByIdAsync(string realm)
        {
            var identityProviderInstances = await IdentityProvidersClient.GetIdentityProviderInstancesAsync(realm);
            string identityProviderAlias = identityProviderInstances.FirstOrDefault()?.Alias;
            if (identityProviderAlias != null)
            {
                var mappers = await IdentityProvidersClient.GetIdentityProviderMappersAsync(realm, identityProviderAlias);
                string mapperId = mappers.FirstOrDefault()?.Id;
                if (mapperId != null)
                {
                    var result = await IdentityProvidersClient.GetIdentityProviderMapperByIdAsync(realm, identityProviderAlias, mapperId);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetIdentityProviderByProviderIdAsync(string realm)
        {
            var identityProviderInstances = await IdentityProvidersClient.GetIdentityProviderInstancesAsync(realm);
            string identityProviderId = identityProviderInstances.FirstOrDefault()?.ProviderId;
            if (identityProviderId != null)
            {
                var result = await IdentityProvidersClient.GetIdentityProviderByProviderIdAsync(realm, identityProviderId);
                Assert.NotNull(result);
            }
        }
    }
}
