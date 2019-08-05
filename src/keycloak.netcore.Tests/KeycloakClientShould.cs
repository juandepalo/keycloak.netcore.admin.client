using System.IO;
using Microsoft.Extensions.Configuration;
namespace Keycloak.Net.Tests
{
    public class KeycloakClientShould
    {
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
            
            if (AttackDetectionClient == null)
                AttackDetectionClient = new AttackDetection.AttackDetection();
            if (AuthenticationManagementClient == null)
                AuthenticationManagementClient = new AuthenticationManagement.AuthenticationManagement();
            if (ClientAttributeCertificateClient == null)
                ClientAttributeCertificateClient = new ClientAttributeCertificate.ClientAttributeCertificate();
            if (ClientInitialAccessClient == null)
                ClientInitialAccessClient = new ClientInitialAccess.ClientInitialAccess();
            if (ClientRegistrationPolicyClient == null)
                ClientRegistrationPolicyClient = new ClientRegistrationPolicy.ClientRegistrationPolicy();
            if (ClientRoleMappingsClient == null)
                ClientRoleMappingsClient = new ClientRoleMappings.ClientRoleMappings();
            if (ClientsClient == null)
                ClientsClient = new Clients.Clients();
            if (ClientScopesClient == null)
                ClientScopesClient = new ClientScopes.ClientScopes();
            if (ComponentsClient == null)
                ComponentsClient = new Components.Components();
            if (GroupsClient == null)
                GroupsClient = new Groups.Groups();
            if (IdentityProvidersClient == null)
                IdentityProvidersClient = new IdentityProviders.IdentityProviders();
            if (KeyClient == null)
                KeyClient = new Key.Key();
            if (ProtocolMappersClient == null)
                ProtocolMappersClient = new ProtocolMappers.ProtocolMappers();
            if (RealmsAdminClient == null)
                RealmsAdminClient = new RealmsAdmin.RealmsAdmin();
            if (RoleMapperClient == null)
                RoleMapperClient = new RoleMapper.RoleMapper();
            if (RolesClient == null)
                RolesClient = new Roles.Roles();
            if (RolesByIdClient == null)
                RolesByIdClient = new RolesById.RolesById();
            if (RootClient == null)
                RootClient = new Root.Root();
            if (ScopeMappingsClient == null)
                ScopeMappingsClient = new ScopeMappings.ScopeMappings();
            if (UsersClient == null)
                UsersClient = new Users.Users();
            if (UserStorageProviderClient == null)
                UserStorageProviderClient = new UserStorageProvider.UserStorageProvider();
        }
    }
}
