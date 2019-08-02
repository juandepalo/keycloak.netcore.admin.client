namespace Keycloak.Net.Tests
{
    public class AttackDetetionShould : KeycloakClientShould
    {
        [Theory]
        [InlineData("Insurance", "vermeulen")]
        public async Task GetUserNameStatusInBruteForceDetectionAsync(string realm, string search)
        {
            var users = await _client.GetUsersAsync(realm, search: search);
            string userId = users.FirstOrDefault()?.Id;
            if (userId != null)
            {
                var result = await _client.GetUserNameStatusInBruteForceDetectionAsync(realm, userId);
                Assert.NotNull(result);
            }
        }
    }
}