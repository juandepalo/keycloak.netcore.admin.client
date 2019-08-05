using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public class GroupsShould : KeycloakClientShould
    {
        [Theory]
        [InlineData("Insurance")]
        public async Task GetGroupHierarchyAsync(string realm)
        {
            var result = await GroupsClient.GetGroupHierarchyAsync(realm);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetGroupsCountAsync(string realm)
        {
            int? result = await GroupsClient.GetGroupsCountAsync(realm);
            Assert.True(result >= 0);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetGroupAsync(string realm)
        {
            var groups = await GroupsClient.GetGroupHierarchyAsync(realm);
            string groupId = groups.FirstOrDefault()?.Id;
            if (groupId != null)
            {
                var result = await GroupsClient.GetGroupAsync(realm, groupId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetGroupClientAuthorizationPermissionsInitializedAsync(string realm)
        {
            var groups = await GroupsClient.GetGroupHierarchyAsync(realm);
            string groupId = groups.FirstOrDefault()?.Id;
            if (groupId != null)
            {
                var result = await GroupsClient.GetGroupClientAuthorizationPermissionsInitializedAsync(realm, groupId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetGroupUsersAsync(string realm)
        {
            var groups = await GroupsClient.GetGroupHierarchyAsync(realm);
            string groupId = groups.FirstOrDefault()?.Id;
            if (groupId != null)
            {
                var result = await GroupsClient.GetGroupUsersAsync(realm, groupId);
                Assert.NotNull(result);
            }
        }
    }
}
