using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public class RolesByIdShould : KeycloakClientShould
    {
        [Theory]
        [InlineData("Insurance")]
        public async Task GetRoleByIdAsync(string realm)
        {
            var roles = await RolesClient.GetRolesAsync(realm);
            string roleId = roles.FirstOrDefault()?.Id;
            if (roleId != null)
            {
                var result = await RolesByIdClient.GetRoleByIdAsync(realm, roleId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetRoleChildrenAsync(string realm)
        {
            var roles = await RolesClient.GetRolesAsync(realm);
            string roleId = roles.FirstOrDefault()?.Id;
            if (roleId != null)
            {
                var result = await RolesByIdClient.GetRoleChildrenAsync(realm, roleId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetClientRolesForCompositeByIdAsync(string realm, string clientId)
        {
            var roles = await RolesClient.GetRolesAsync(realm);
            string roleId = roles.FirstOrDefault()?.Id;
            if (roleId != null)
            {
                var clients = await ClientsClient.GetClientsAsync(realm);
                string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
                if (clientsId != null)
                {
                    var result = await RolesByIdClient.GetClientRolesForCompositeByIdAsync(realm, roleId, clientsId);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetRealmRolesForCompositeByIdAsync(string realm)
        {
            var roles = await RolesClient.GetRolesAsync(realm);
            string roleId = roles.FirstOrDefault()?.Id;
            if (roleId != null)
            {
                var result = await RolesByIdClient.GetRealmRolesForCompositeByIdAsync(realm, roleId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetRoleByIdAuthorizationPermissionsInitializedAsync(string realm)
        {
            var roles = await RolesClient.GetRolesAsync(realm);
            string roleId = roles.FirstOrDefault()?.Id;
            if (roleId != null)
            {
                var result = await RolesByIdClient.GetRoleByIdAuthorizationPermissionsInitializedAsync(realm, roleId);
                Assert.NotNull(result);
            }
        }
    }
}
