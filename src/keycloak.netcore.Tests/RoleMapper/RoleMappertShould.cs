using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public class RoleMappertShould : KeycloakClientShould
    {
        [Theory]
        [InlineData("Insurance")]
        public async Task GetRoleMappingsForGroupAsync(string realm)
        {
            var groups = await GroupsClient.GetGroupHierarchyAsync(realm);
            string groupId = groups.FirstOrDefault()?.Id;
            if (groupId != null)
            {
                var result = await RoleMapperClient.GetRoleMappingsForGroupAsync(realm, groupId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetRealmRoleMappingsForGroupAsync(string realm)
        {
            var groups = await GroupsClient.GetGroupHierarchyAsync(realm);
            string groupId = groups.FirstOrDefault()?.Id;
            if (groupId != null)
            {
                var result = await RoleMapperClient.GetRealmRoleMappingsForGroupAsync(realm, groupId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetAvailableRealmRoleMappingsForGroupAsync(string realm)
        {
            var groups = await GroupsClient.GetGroupHierarchyAsync(realm);
            string groupId = groups.FirstOrDefault()?.Id;
            if (groupId != null)
            {
                var result = await RoleMapperClient.GetAvailableRealmRoleMappingsForGroupAsync(realm, groupId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetEffectiveRealmRoleMappingsForGroupAsync(string realm)
        {
            var groups = await GroupsClient.GetGroupHierarchyAsync(realm);
            string groupId = groups.FirstOrDefault()?.Id;
            if (groupId != null)
            {
                var result = await RoleMapperClient.GetEffectiveRealmRoleMappingsForGroupAsync(realm, groupId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetRoleMappingsForUserAsync(string realm)
        {
            var users = await UsersClient.GetUsersAsync(realm);
            string userId = users.FirstOrDefault()?.Id;
            if (userId != null)
            {
                var result = await RoleMapperClient.GetRoleMappingsForUserAsync(realm, userId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetRealmRoleMappingsForUserAsync(string realm)
        {
            var users = await UsersClient.GetUsersAsync(realm);
            string userId = users.FirstOrDefault()?.Id;
            if (userId != null)
            {
                var result = await RoleMapperClient.GetRealmRoleMappingsForUserAsync(realm, userId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetAvailableRealmRoleMappingsForUserAsync(string realm)
        {
            var users = await UsersClient.GetUsersAsync(realm);
            string userId = users.FirstOrDefault()?.Id;
            if (userId != null)
            {
                var result = await RoleMapperClient.GetAvailableRealmRoleMappingsForUserAsync(realm, userId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetEffectiveRealmRoleMappingsForUserAsync(string realm)
        {
            var users = await UsersClient.GetUsersAsync(realm);
            string userId = users.FirstOrDefault()?.Id;
            if (userId != null)
            {
                var result = await RoleMapperClient.GetEffectiveRealmRoleMappingsForUserAsync(realm, userId);
                Assert.NotNull(result);
            }
        }
    }
}
