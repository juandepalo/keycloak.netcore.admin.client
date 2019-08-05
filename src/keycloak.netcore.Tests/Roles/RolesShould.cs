using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public class RolesShould : KeycloakClientShould
    {
        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetRolesForClientAsync(string realm, string clientId)
        {
            var clients = await ClientsClient.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await RolesClient.GetRolesAsync(realm, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetRoleByNameForClientAsync(string realm, string clientId)
        {
            var clients = await ClientsClient.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var roles = await RolesClient.GetRolesAsync(realm, clientsId);
                string roleName = roles.FirstOrDefault()?.Name;
                if (roleName != null)
                {
                    var result = await RolesClient.GetRoleByNameAsync(realm, clientsId, roleName);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetRoleCompositesForClientAsync(string realm, string clientId)
        {
            var clients = await ClientsClient.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var roles = await RolesClient.GetRolesAsync(realm, clientsId);
                string roleName = roles.FirstOrDefault()?.Name;
                if (roleName != null)
                {
                    var result = await RolesClient.GetRoleCompositesAsync(realm, clientsId, roleName);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetApplicationRolesForCompositeForClientAsync(string realm, string clientId)
        {
            var clients = await ClientsClient.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var roles = await RolesClient.GetRolesAsync(realm, clientsId);
                string roleName = roles.FirstOrDefault()?.Name;
                if (roleName != null)
                {
                    var result = await RolesClient.GetApplicationRolesForCompositeAsync(realm, clientsId, roleName, clientsId);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetRealmRolesForCompositeForClientAsync(string realm, string clientId)
        {
            var clients = await ClientsClient.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var roles = await RolesClient.GetRolesAsync(realm, clientsId);
                string roleName = roles.FirstOrDefault()?.Name;
                if (roleName != null)
                {
                    var result = await RolesClient.GetRealmRolesForCompositeAsync(realm, clientsId, roleName);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory(Skip = "Not working yet")]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetGroupsWithRoleNameForClientAsync(string realm, string clientId)
        {
            var clients = await ClientsClient.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var roles = await RolesClient.GetRolesAsync(realm, clientsId);
                string roleName = roles.FirstOrDefault()?.Name;
                if (roleName != null)
                {
                    var result = await RolesClient.GetGroupsWithRoleNameAsync(realm, clientsId, roleName);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetRoleAuthorizationPermissionsInitializedForClientAsync(string realm, string clientId)
        {
            var clients = await ClientsClient.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var roles = await RolesClient.GetRolesAsync(realm, clientsId);
                string roleName = roles.FirstOrDefault()?.Name;
                if (roleName != null)
                {
                    var result = await RolesClient.GetRoleAuthorizationPermissionsInitializedAsync(realm, clientsId, roleName);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetUsersWithRoleNameForClientAsync(string realm, string clientId)
        {
            var clients = await ClientsClient.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var roles = await RolesClient.GetRolesAsync(realm, clientsId);
                string roleName = roles.FirstOrDefault()?.Name;
                if (roleName != null)
                {
                    var result = await RolesClient.GetUsersWithRoleNameAsync(realm, clientsId, roleName);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetRolesForRealmAsync(string realm)
        {
            var result = await RolesClient.GetRolesAsync(realm);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetRoleByNameForRealmAsync(string realm)
        {
            var roles = await RolesClient.GetRolesAsync(realm);
            string roleName = roles.FirstOrDefault()?.Name;
            if (roleName != null)
            {
                var result = await RolesClient.GetRoleByNameAsync(realm, roleName);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetRoleCompositesForRealmAsync(string realm)
        {
            var roles = await RolesClient.GetRolesAsync(realm);
            string roleName = roles.FirstOrDefault()?.Name;
            if (roleName != null)
            {
                var result = await RolesClient.GetRoleCompositesAsync(realm, roleName);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetApplicationRolesForCompositeForRealmAsync(string realm, string clientId)
        {
            var clients = await ClientsClient.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var roles = await RolesClient.GetRolesAsync(realm);
                string roleName = roles.FirstOrDefault()?.Name;
                if (roleName != null)
                {
                    var result = await RolesClient.GetApplicationRolesForCompositeAsync(realm, roleName, clientsId);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetRealmRolesForCompositeForRealmAsync(string realm)
        {
            var roles = await RolesClient.GetRolesAsync(realm);
            string roleName = roles.FirstOrDefault()?.Name;
            if (roleName != null)
            {
                var result = await RolesClient.GetRealmRolesForCompositeAsync(realm, roleName);
                Assert.NotNull(result);
            }
        }

        [Theory(Skip = "Not working yet")]
        [InlineData("Insurance")]
        public async Task GetGroupsWithRoleNameForRealmAsync(string realm)
        {
            var roles = await RolesClient.GetRolesAsync(realm);
            string roleName = roles.FirstOrDefault()?.Name;
            if (roleName != null)
            {
                var result = await RolesClient.GetGroupsWithRoleNameAsync(realm, roleName);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetRoleAuthorizationPermissionsInitializedForRealmAsync(string realm)
        {
            var roles = await RolesClient.GetRolesAsync(realm);
            string roleName = roles.FirstOrDefault()?.Name;
            if (roleName != null)
            {
                var result = await RolesClient.GetRoleAuthorizationPermissionsInitializedAsync(realm, roleName);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetUsersWithRoleNameForRealmAsync(string realm)
        {
            var roles = await RolesClient.GetRolesAsync(realm);
            string roleName = roles.FirstOrDefault()?.Name;
            if (roleName != null)
            {
                var result = await RolesClient.GetUsersWithRoleNameAsync(realm, roleName);
                Assert.NotNull(result);
            }
        }
    }
}
