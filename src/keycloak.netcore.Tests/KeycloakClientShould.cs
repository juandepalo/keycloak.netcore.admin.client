using System.IO;
using Microsoft.Extensions.Configuration;
using Keycloak.Net.Root;
using Keycloak.Net.AttackDetection;
namespace Keycloak.Net.Tests
{
    public class KeycloakClientShould
    {
        public string Url { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public static AttackDetection.AttackDetection AttackDetectionClient { get; set; }
        public static AuthenticationManagement.AuthenticationManagement AuthenticationManagementClient { get; set; }
        public static ClientAttributeCertificate.ClientAttributeCertificate ClientAttributeCertificateClient { get; set; }
        public static ClientInitialAccess.ClientInitialAccess ClientInitialAccessClient { get; set; }
        public static ClientRegistrationPolicy.ClientRegistrationPolicy ClientRegistrationPolicyClient { get; set; }
        public static ClientRoleMappings.ClientRoleMappings ClientRoleMappingsClient { get; set; }
        public static Clients.Clients ClientsClient { get; set; }
        public static ClientScopes.ClientScopes ClientScopesClient { get; set; }
        public static Components.Components ComponentsClient { get; set; }
        public static Groups.Groups GroupsClient { get; set; }
        public static IdentityProviders.IdentityProviders IdentityProvidersClient { get; set; }
        public static Key.Key KeyClient { get; set; }
        public static ProtocolMappers.ProtocolMappers ProtocolMappersClient { get; set; }
        public static RealmsAdmin.RealmsAdmin RealmsAdminClient { get; set; }
        public static RoleMapper.RoleMapper RoleMapperClient { get; set; }
        public static Roles.Roles RolesClient { get; set; }
        public static RolesById.RolesById RolesByIdClient { get; set; }
        public static Root.Root RootClient { get; set; }
        public static ScopeMappings.ScopeMappings ScopeMappingsClient { get; set; }
        public static Users.Users UsersClient { get; set; }
        public static UserStorageProvider.UserStorageProvider UserStorageProviderClient { get; set; }
        public KeycloakClientShould()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            Url = configuration["url"];
            UserName = configuration["userName"];
            Password = configuration["password"];
            if (AttackDetectionClient == null)
                AttackDetectionClient = new AttackDetection.AttackDetection(Url, UserName, Password);
            if (AuthenticationManagementClient == null)
                AuthenticationManagementClient = new AuthenticationManagement.AuthenticationManagement(Url, UserName, Password);
            if (ClientAttributeCertificateClient == null)
                ClientAttributeCertificateClient = new ClientAttributeCertificate.ClientAttributeCertificate(Url, UserName, Password);
            if (ClientInitialAccessClient == null)
                ClientInitialAccessClient = new ClientInitialAccess.ClientInitialAccess(Url, UserName, Password);
            if (ClientRegistrationPolicyClient == null)
                ClientRegistrationPolicyClient = new ClientRegistrationPolicy.ClientRegistrationPolicy(Url, UserName, Password);
            if (ClientRoleMappingsClient == null)
                ClientRoleMappingsClient = new ClientRoleMappings.ClientRoleMappings(Url, UserName, Password);
            if (ClientsClient == null)
                ClientsClient = new Clients.Clients(Url, UserName, Password);
            if (ClientScopesClient == null)
                ClientScopesClient = new ClientScopes.ClientScopes(Url, UserName, Password);
            if (ComponentsClient == null)
                ComponentsClient = new Components.Components(Url, UserName, Password);
            if (GroupsClient == null)
                GroupsClient = new Groups.Groups(Url, UserName, Password);
            if (IdentityProvidersClient == null)
                IdentityProvidersClient = new IdentityProviders.IdentityProviders(Url, UserName, Password);
            if (KeyClient == null)
                KeyClient = new Key.Key(Url, UserName, Password);
            if (ProtocolMappersClient == null)
                ProtocolMappersClient = new ProtocolMappers.ProtocolMappers(Url, UserName, Password);
            if (RealmsAdminClient == null)
                RealmsAdminClient = new RealmsAdmin.RealmsAdmin(Url, UserName, Password);
            if (RoleMapperClient == null)
                RoleMapperClient = new RoleMapper.RoleMapper(Url, UserName, Password);
            if (RolesClient == null)
                RolesClient = new Roles.Roles(Url, UserName, Password);
            if (RolesByIdClient == null)
                RolesByIdClient = new RolesById.RolesById(Url, UserName, Password);
            if (RootClient == null)
                RootClient = new Root.Root(Url, UserName, Password);
            if (ScopeMappingsClient == null)
                ScopeMappingsClient = new ScopeMappings.ScopeMappings(Url, UserName, Password);
            if (UsersClient == null)
                UsersClient = new Users.Users(Url, UserName, Password);
            if (UserStorageProviderClient == null)
                UserStorageProviderClient = new UserStorageProvider.UserStorageProvider(Url, UserName, Password);
        }
    }
}
