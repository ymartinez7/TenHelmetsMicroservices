using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace TenHelmets.MS.UI.Administration.WebApi
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddSwaggerGen(config =>
            {
                //config.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info()
                //{
                //    Title = "10Helmets APIs RESTful Administration"
                //});

                config.SwaggerDoc("v1", new OpenApiInfo { Title = "10Helmets APIs RESTful Administration", Version = "v1" });

                config.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                {
                    Type = SecuritySchemeType.OAuth2,
                    Flows = new OpenApiOAuthFlows
                    {
                        //Implicit = new OpenApiOAuthFlow
                        //{
                        //    AuthorizationUrl = new Uri("https://localhost:44398", UriKind.Absolute),
                        //    Scopes = new Dictionary<string, string>
                        //    {
                        //        { "readAccess", "Access read operations" },
                        //        { "writeAccess", "Access write operations" }
                        //    }
                        //},
                        Password = new OpenApiOAuthFlow
                        {
                            AuthorizationUrl = new Uri("https://localhost:44398", UriKind.Absolute),
                            Scopes = new Dictionary<string, string>
                            {
                                { "readAccess", "Access read operations" },
                                { "writeAccess", "Access write operations" }
                            }
                        }
                    }
                });

                config.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "oauth2" }
                        },
                        new[] { "readAccess", "writeAccess" }
                    }
                });


                //config.AddSecurityDefinition("Bearer", new OAuth2Scheme
                //{
                //    Description = "OAuth authentication",
                //    TokenUrl = "https://localhost:44398",
                //    Flow = "Pasword",
                //    Type="oauth2"
                //});

                //var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                //var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                //config.IncludeXmlComments(xmlPath);
            });


            // Authentication Identity Server 4
            services.AddAuthentication("Bearer")
                .AddIdentityServerAuthentication(config =>
                {
                    config.Authority = "https://localhost:44398";
                    config.RequireHttpsMetadata = false;
                    config.ApiName = "administration-api";
                });
        }

        public void Configure(IApplicationBuilder app,
            IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseCors(options =>
            {
                options.AllowAnyOrigin();
                options.AllowAnyMethod();
                options.AllowAnyHeader();
            });

            app.UseSwagger();
            app.UseSwaggerUI(config =>
            {
                config.SwaggerEndpoint("../swagger/v1/swagger.json", "Backend API Administration");
                config.OAuthClientId("cleint-id");
                config.OAuthClientSecret("client-secret");
                config.OAuthRealm("client-realm");
                config.OAuthAppName("OAuth-app");
                config.OAuthUseBasicAuthenticationWithAccessCodeGrant();
            });

            app.UseAuthentication();
            app.UseMvc();
        }
    }
}