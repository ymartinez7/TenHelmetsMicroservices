using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.IO;
using System.Reflection;

namespace TenHelmets.MS.UI.Direction.WebApi
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
                //    Title = "10Helmets APIs RESTful Direction"
                //});

                config.SwaggerDoc("v1", new OpenApiInfo { Title = "10Helmets APIs RESTful Direction", Version = "v1" });

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
                    config.ApiName = "constrction-api";
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
                config.SwaggerEndpoint("../swagger/v1/swagger.json", "Backend API Direction");
            });

            app.UseAuthentication();
            app.UseMvc();
        }
    }
}
