using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public class UserStorageProviderShould : KeycloakClientShould
    {
        [Theory(Skip = "Not working yet")]
        [InlineData("Insurance")]
        public async Task TriggerUserSynchronizationAsync(string realm)
        {
            string storageProviderId = "";
            var result = await UserStorageProviderClient.TriggerUserSynchronizationAsync(realm, storageProviderId, UserSyncActions.Full);
            Assert.NotNull(result);
        }

        [Theory(Skip = "Not working yet")]
        [InlineData("Insurance")]
        public async Task TriggerLdapMapperSynchronizationAsync(string realm)
        {
            string storageProviderId = "";
            string mapperId = "";
            var result = await UserStorageProviderClient.TriggerLdapMapperSynchronizationAsync(realm, storageProviderId, mapperId, LdapMapperSyncActions.KeycloakToFed);
            Assert.NotNull(result);
        }
    }
}
