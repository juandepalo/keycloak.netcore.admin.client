﻿using Keycloak.Authentication.Handlers.Requirements;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;

namespace Keycloak.Authentication.Policies
{
    public class KeycloakRoleAuthorizationPolicy : AuthorizationPolicy
    {
        public KeycloakRoleAuthorizationPolicy(string role)
            : base(new IAuthorizationRequirement[] { new HasRoleRequirement(role) }, new string[] { })
        {
        }

        public KeycloakRoleAuthorizationPolicy(IEnumerable<IAuthorizationRequirement> requirements, IEnumerable<string> authenticationSchemes) : base(requirements, authenticationSchemes)
        {
        }
    }
}
