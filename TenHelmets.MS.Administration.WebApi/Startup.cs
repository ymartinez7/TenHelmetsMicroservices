using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
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

                //var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                //var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                //config.IncludeXmlComments(xmlPath);
            });



            services.AddAuthentication("Bearer")
                .AddJwtBearer("Bearer", config =>
                {
                    config.MetadataAddress = "http://localhost:65176";
                    config.Audience = "ApiOne";
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
            });

            //app.UseAuthentication();

            app.UseMvc();
        }
    }
}