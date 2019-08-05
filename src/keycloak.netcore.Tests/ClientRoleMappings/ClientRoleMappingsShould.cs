using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public class ClientRoleMappingsShould : KeycloakClientShould
    {
        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetClientRoleMappingsForGroupAsync(string realm, string clientId)
        {
            var groups = await GroupsClient.GetGroupHierarchyAsync(realm);
            string groupId = groups.FirstOrDefault()?.Id;
            if (groupId != null)
            {
                var clients = await ClientsClient.GetClientsAsync(realm);
                string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
                if (clientId != null)
                {
                    var result = await ClientRoleMappingsClient.GetClientRoleMappingsForGroupAsync(realm, groupId, clientsId);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetAvailableClientRoleMappingsForGroupAsync(string realm, string clientId)
        {
            var groups = await GroupsClient.GetGroupHierarchyAsync(realm);
            string groupId = groups.FirstOrDefault()?.Id;
            if (groupId != null)
            {
                var clients = await ClientsClient.GetClientsAsync(realm);
                string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
                if (clientId != null)
                {
                    var result = await ClientRoleMappingsClient.GetAvailableClientRoleMappingsForGroupAsync(realm, groupId, clientsId);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetEffectiveClientRoleMappingsForGroupAsync(string realm, string clientId)
        {
            var groups = await GroupsClient.GetGroupHierarchyAsync(realm);
            string groupId = groups.FirstOrDefault()?.Id;
            if (groupId != null)
            {
                var clients = await ClientsClient.GetClientsAsync(realm);
                string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
                if (clientId != null)
                {
                    var result = await ClientRoleMappingsClient.GetEffectiveClientRoleMappingsForGroupAsync(realm, groupId, clientsId);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetClientRoleMappingsForUserAsync(string realm, string clientId)
        {
            var users = await UsersClient.GetUsersAsync(realm);
            string userId = users.FirstOrDefault()?.Id;
            if (userId != null)
            {
                var clients = await ClientsClient.GetClientsAsync(realm);
                string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
                if (clientId != null)
                {
                    var result = await ClientRoleMappingsClient.GetClientRoleMappingsForUserAsync(realm, userId, clientsId);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetAvailableClientRoleMappingsForUserAsync(string realm, string clientId)
        {
            var users = await UsersClient.GetUsersAsync(realm);
            string userId = users.FirstOrDefault()?.Id;
            if (userId != null)
            {
                var clients = await ClientsClient.GetClientsAsync(realm);
                string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
                if (clientId != null)
                {
                    var result = await ClientRoleMappingsClient.GetAvailableClientRoleMappingsForUserAsync(realm, userId, clientsId);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetEffectiveClientRoleMappingsForUserAsync(string realm, string clientId)
        {
            var users = await UsersClient.GetUsersAsync(realm);
            string userId = users.FirstOrDefault()?.Id;
            if (userId != null)
            {
                var clients = await ClientsClient.GetClientsAsync(realm);
                string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
                if (clientId != null)
                {
                    var result = await ClientRoleMappingsClient.GetEffectiveClientRoleMappingsForUserAsync(realm, userId, clientsId);
                    Assert.NotNull(result);
                }
            }
        }
    }
}
