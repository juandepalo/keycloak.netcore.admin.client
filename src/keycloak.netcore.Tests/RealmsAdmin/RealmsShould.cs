using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public class RealmsShould :KeycloakClientShould
    {
        [Theory]
        [InlineData("Insurance")]
        public async Task GetRealmAsync(string realm)
        {
            var result = await RealmsAdminClient.GetRealmAsync(realm);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetAdminEventsAsync(string realm)
        {
            var result = await RealmsAdminClient.GetAdminEventsAsync(realm);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetClientSessionStatsAsync(string realm)
        {
            var result = await RealmsAdminClient.GetClientSessionStatsAsync(realm);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetRealmDefaultClientScopesAsync(string realm)
        {
            var result = await RealmsAdminClient.GetRealmDefaultClientScopesAsync(realm);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetRealmGroupHierarchyAsync(string realm)
        {
            var result = await RealmsAdminClient.GetRealmGroupHierarchyAsync(realm);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetRealmOptionalClientScopesAsync(string realm)
        {
            var result = await RealmsAdminClient.GetRealmOptionalClientScopesAsync(realm);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetEventsAsync(string realm)
        {
            var result = await RealmsAdminClient.GetEventsAsync(realm);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetRealmEventsProviderConfigurationAsync(string realm)
        {
            var result = await RealmsAdminClient.GetRealmEventsProviderConfigurationAsync(realm);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetRealmGroupByPathAsync(string realm)
        {
            var groups = await RealmsAdminClient.GetRealmGroupHierarchyAsync(realm);
            string path = groups.FirstOrDefault()?.Path;
            if (path != null)
            {
                var result = await RealmsAdminClient.GetRealmGroupByPathAsync(realm, path);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetRealmUsersManagementPermissionsAsync(string realm)
        {
            var result = await RealmsAdminClient.GetRealmUsersManagementPermissionsAsync(realm);
            Assert.NotNull(result);
        }
    }
}
