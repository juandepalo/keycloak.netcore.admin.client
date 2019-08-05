using Xunit;
using System.Linq;
using System.Threading.Tasks;

namespace Keycloak.Net.Tests
{
    public class AttackDetetionShould : KeycloakClientShould
    {


        [Theory]
        [InlineData("Insurance", "vermeulen")]
        public async Task GetUserNameStatusInBruteForceDetectionAsync(string realm, string search)
        {
            var users = await UsersClient.GetUsersAsync(realm, search: search);
            string userId = users.FirstOrDefault()?.Id;
            if (userId != null)
            {
                var result = await AttackDetectionClient.GetUserNameStatusInBruteForceDetectionAsync(realm, userId);
                Assert.NotNull(result);
            }
        }
    }
}