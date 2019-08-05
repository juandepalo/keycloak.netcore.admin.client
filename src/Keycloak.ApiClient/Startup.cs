using System.Linq;
using Keycloak.ApiClient.Configurations;
using Keycloak.ApiClient.Models;
using Keycloak.Authentication;
using Keycloak.Authentication.Clients;
using Keycloak.Authentication.Configuration;
using Keycloak.Authentication.Handlers.Requirements;
using Keycloak.Authentication.Policies;
using Keycloak.Net.AttackDetection;
using Keycloak.Net.AuthenticationManagement;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NSwag;
using NSwag.AspNetCore;


namespace Keycloak.ApiClient
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(env.ContentRootPath)
            .AddJsonFile("appsettings.json", true, true)
            .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true);
            Configuration = Configuration = builder.Build();
            Environment = env;
            token = Configuration.GetSection("tokenManagement").Get<TokenManagement>();
        }
        public IConfiguration Configuration { get; }
        public IHostingEnvironment Environment { get; }
        public TokenManagement token { get; }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options =>
            {
                options.OutputFormatters.Remove(new XmlDataContractSerializerOutputFormatter());
            }).SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddAutoMapperSetup();

            // Register the Swagger services
            #region openapi
            services.AddOpenApiDocument(document =>
            {
                document.AddSecurity("bearer", Enumerable.Empty<string>(), new OpenApiSecurityScheme
                {
                    Type = OpenApiSecuritySchemeType.OAuth2,
                    Flow = OpenApiOAuth2Flow.Implicit,
                    Flows = new OpenApiOAuthFlows()
                    {
                        Implicit = new OpenApiOAuthFlow()
                        {
                            AuthorizationUrl = token.AuthorizationUrl,
                            TokenUrl = token.tokenUrl,
                        }

                    }
                });
            });
            #endregion
            #region autthentication-keycloak

            services.AddKeycloakAuthentication(new KeycloakOptions
            {
                Realm = token.Realm,
                ClientId = token.ClientId,
                ClientSecret = token.Secret,
                KeycloakUrl = token.Authority,
                EnableGetTokenAuto = true,
                EnableRefreshToken = true
            });
            // services.AddAuthorization();
            services.AddAuthorization(
                config =>
                {
                    config.AddPolicy("administrador", policy => policy.AddRequirements(new IAuthorizationRequirement[] { new HasRoleRequirement("adminitrador") }));
                    config.AddPolicy("invitado", policy => policy.AddRequirements(new IAuthorizationRequirement[] { new HasRoleRequirement("invitado") }));


                    config.AddPolicy("administrador", new KeycloakRoleAuthorizationPolicy("administrador"));
                    config.AddPolicy("invitado", new KeycloakRoleAuthorizationPolicy("invitado"));
                    // config.AddPolicy("admin", policy => policy.RequireClaim("user_roles", "[admin]"));

                }
            );

            #endregion

            #region Injeccion
            services.AddScoped<IKeycloakClient, KeycloakClient>();
            services.AddScoped<IAttackDetection, AttackDetection>();
            services.AddScoped<IAuthenticationManagement, AuthenticationManagement>();
            #endregion

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //app.UseHttpsRedirection();
            app.UseStaticFiles();
            //app.UseCookiePolicy();
            // app.UseAuthentication();
            app.UseKeycloak(); //Habilitar la autenticación de Keycloak
            app.UseOpenApi();
            app.UseSwaggerUi3(settings =>
            {
                settings.OAuth2Client = new OAuth2ClientSettings
                {
                    ClientId = token.ClientId,
                    ClientSecret = token.Secret,
                    AppName = token.AppName,
                    Realm = token.Realm
                };

            });
            app.UseMvc();
        }
    }
}
