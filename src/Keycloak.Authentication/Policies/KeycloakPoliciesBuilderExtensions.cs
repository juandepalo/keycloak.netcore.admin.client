using Keycloak.Authentication.Handlers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Keycloak.Authentication.Policies
{
    public static class KeycloakPoliciesBuilderExtensions
    {
        /// <summary>
        /// Agrega al HttpClient la funcionalidad de obtener y refrescar el token de forma automatica.
        /// </summary>
        /// <param name="httpClientBuilder"></param>
        /// <returns>Devuelve el IHttpClientBuilder para concatenar más métodos.</returns>
        public static IHttpClientBuilder AddHttpKeycloakGetAutoTokenHandler(this IHttpClientBuilder httpClientBuilder)
        {
            return httpClientBuilder.AddHttpMessageHandler<HttpGetTokenAutoHandler>();
        }
    }
}
