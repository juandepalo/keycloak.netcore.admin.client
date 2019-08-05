using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public class AuthenticationManagementShould : KeycloakClientShould
    {
        [Theory]
        [InlineData("Insurance")]
        public async Task GetAuthenticatorProvidersAsync(string realm)
        {
            var result = await AuthenticationManagementClient.GetAuthenticatorProvidersAsync(realm);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetClientAuthenticatorProvidersAsync(string realm)
        {
            var result = await AuthenticationManagementClient.GetClientAuthenticatorProvidersAsync(realm);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetAuthenticatorProviderConfigurationDescriptionAsync(string realm)
        {
            var providers = await AuthenticationManagementClient.GetAuthenticatorProvidersAsync(realm);
            string providerId = providers.FirstOrDefault()?.FirstOrDefault(x => x.Key == "id").Value.ToString();
            if (providerId != null)
            {
                var result = await AuthenticationManagementClient.GetAuthenticatorProviderConfigurationDescriptionAsync(realm, providerId);
                Assert.NotNull(result);
            }
        }

        [Theory(Skip = "Not working yet")]
        [InlineData("Insurance")]
        public async Task GetAuthenticatorConfigurationAsync(string realm)
        {
            string configurationId = ""; //TODO
            if (configurationId != null)
            {
                var result = await AuthenticationManagementClient.GetAuthenticatorConfigurationAsync(realm, configurationId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetAuthenticationExecutionAsync(string realm)
        {
            var flows = await AuthenticationManagementClient.GetAuthenticationFlowsAsync(realm);
            string flowAlias = flows.FirstOrDefault()?.Alias;
            if (flowAlias != null)
            {
                var executions = await AuthenticationManagementClient.GetAuthenticationFlowExecutionsAsync(realm, flowAlias);
                string executionId = executions.FirstOrDefault()?.Id;
                if (executionId != null)
                {
                    var result = await AuthenticationManagementClient.GetAuthenticationExecutionAsync(realm, executionId);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetAuthenticationFlowsAsync(string realm)
        {
            var result = await AuthenticationManagementClient.GetAuthenticationFlowsAsync(realm);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetAuthenticationFlowExecutionsAsync(string realm)
        {
            var flows = await AuthenticationManagementClient.GetAuthenticationFlowsAsync(realm);
            string flowAlias = flows.FirstOrDefault()?.Alias;
            if (flowAlias != null)
            {
                var result = await AuthenticationManagementClient.GetAuthenticationFlowExecutionsAsync(realm, flowAlias);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetAuthenticationFlowByIdAsync(string realm)
        {
            var flows = await AuthenticationManagementClient.GetAuthenticationFlowsAsync(realm);
            string flowId = flows.FirstOrDefault()?.Id;
            if (flowId != null)
            {
                var result = await AuthenticationManagementClient.GetAuthenticationFlowByIdAsync(realm, flowId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetFormActionProvidersAsync(string realm)
        {
            var result = await AuthenticationManagementClient.GetFormActionProvidersAsync(realm);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetFormProvidersAsync(string realm)
        {
            var result = await AuthenticationManagementClient.GetFormProvidersAsync(realm);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetConfigurationDescriptionsForAllClientsAsync(string realm)
        {
            var result = await AuthenticationManagementClient.GetConfigurationDescriptionsForAllClientsAsync(realm);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetRequiredActionsAsync(string realm)
        {
            var result = await AuthenticationManagementClient.GetRequiredActionsAsync(realm);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetRequiredActionByAliasAsync(string realm)
        {
            var requiredActions = await AuthenticationManagementClient.GetRequiredActionsAsync(realm);
            string requiredActionAlias = requiredActions.FirstOrDefault()?.Alias;
            if (requiredActionAlias != null)
            {
                var result = await AuthenticationManagementClient.GetRequiredActionByAliasAsync(realm, requiredActionAlias);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance")]
        public async Task GetUnregisteredRequiredActionsAsync(string realm)
        {
            var result = await AuthenticationManagementClient.GetUnregisteredRequiredActionsAsync(realm);
            Assert.NotNull(result);
        }
    }
}
