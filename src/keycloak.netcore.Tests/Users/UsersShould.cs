using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public class UsersShould: KeycloakClientShould
    {



        [Theory]
        [InlineData("Insurance")]
        public async Task GetUsersAsync(string realm)
        {
            var result = await UsersClient.GetUsersAsync(realm);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetUsersCountAsync(string realm)
        {
            int? result = await UsersClient.GetUsersCountAsync(realm);
            Assert.True(result >= 0);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetUserAsync(string realm)
        {
            var users = await UsersClient.GetUsersAsync(realm);
            string userId = users.FirstOrDefault()?.Id;
            if (userId != null)
            {
                var result = await UsersClient.GetUserAsync(realm, userId);
                Assert.NotNull(result);
                Assert.Equal(userId, result.Id);
            }
        }

        [Theory]
        [InlineData("Insurance", "vermeulen")]
        public async Task GetUserSocialLoginsAsync(string realm, string search)
        {
            var users = await UsersClient.GetUsersAsync(realm, search: search);
            string userId = users.FirstOrDefault()?.Id;
            if (userId != null)
            {
                var result = await UsersClient.GetUserSocialLoginsAsync(realm, userId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance", "vermeulen")]
        public async Task GetUserGroupsAsync(string realm, string search)
        {
            var users = await UsersClient.GetUsersAsync(realm, search: search);
            string userId = users.FirstOrDefault()?.Id;
            if (userId != null)
            {
                var result = await UsersClient.GetUserGroupsAsync(realm, userId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance", "vermeulen")]
        public async Task GetUserGroupsCountAsync(string realm, string search)
        {
            var users = await UsersClient.GetUsersAsync(realm, search: search);
            string userId = users.FirstOrDefault()?.Id;
            if (userId != null)
            {
                int? result = await UsersClient.GetUserGroupsCountAsync(realm, userId);
                Assert.True(result >= 0);
            }
        }

        [Theory]
        [InlineData("Insurance", "vermeulen")]
        public async Task GetUserSessionsAsync(string realm, string search)
        {
            var users = await UsersClient.GetUsersAsync(realm, search: search);
            string userId = users.FirstOrDefault()?.Id;
            if (userId != null)
            {
                var result = await UsersClient.GetUserSessionsAsync(realm, userId);
                Assert.NotNull(result);
            }
        }
    }
}
