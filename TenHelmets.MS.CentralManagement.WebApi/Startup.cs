﻿using TenHelmets.MS.Core.Interfaces.Repositories;
using TenHelmets.MS.Core.Interfaces.Services;
using TenHelmets.MS.Core.Services;
using TenHelmets.MS.Infrastructure.Data.Context;
using TenHelmets.MS.Infrastructure.Data.Repositories;
using TenHelmets.MS.Infrastructure.Identity;
using TenHelmets.MS.UI.CentralManagement.WebApi.Mapper;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IO;
using System.Reflection;
using System.Text;
using Microsoft.OpenApi.Models;

namespace TenHelmets.MS.UI.CentralManagement.WebApi
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
            // EF
            services.AddDbContextPool<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("10HelmetsConnectionString")));

            // Identity
            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            // Authentication
            //services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            //    .AddJwtBearer(options => 
            //    options.TokenValidationParameters = new TokenValidationParameters
            //    {
            //        ValidateIssuer = true,
            //        ValidateAudience = true,
            //        ValidateLifetime = true,
            //        ValidateIssuerSigningKey = true,
            //        ValidIssuer = "yourdomain.com",
            //        ValidAudience = "yourdomain.com",
            //        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Secret_Key"])),
            //        ClockSkew = TimeSpan.Zero
            //    });

            // Configuraciòn del auto mapeador
            var configuracionMapeo = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MapperConfig());
            });
            IMapper mapeador = configuracionMapeo.CreateMapper();
            services.AddSingleton(mapeador);

            // Service injection
            services.AddTransient(typeof(IBaseService<>), typeof(BaseService<>));
            services.AddTransient<IActionTypeService, ActionTypeService>();
            services.AddTransient<IAlertService, AlertService>();
            services.AddTransient<IAlertTypeService, AlertTypeService>();
            services.AddTransient<IBrandService, BrandService>();
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IEventLogService, EventLogService>();
            //services.AddTransient<IFileService, FileService>();
            services.AddTransient<IModelService, ModelService>();
            services.AddTransient<IOrganizationService, OrganizationService>();
            services.AddTransient<IPriorityService, PriorityService>();
            services.AddTransient<IRequestService, RequestService>();
            services.AddTransient<IRequestTypeService, RequestTypeService>();
            services.AddTransient<IResourceRequestService, ResourceRequestService>();
            services.AddTransient<IResourceService, ResourceService>();
            services.AddTransient<IResourceTypeService, ResourceTypeService>();
            services.AddTransient<ISectorService, SectorService>();
            services.AddTransient<IUnitService, UnitService>();

            // Repositories injection
            services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddTransient<IActionTypeRepository, ActionTypeRepository>();
            services.AddTransient<IAlertRepository, AlertRepository>();
            services.AddTransient<IAlertTypeRepository, AlertTypeRepository>();
            services.AddTransient<IBrandRepository, BrandRepository>();
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IEventLogRepository, EventLogRepository>();
            //services.AddTransient<IFileRepository, FileRepository>();
            services.AddTransient<IModelRepository, ModelRepository>();
            services.AddTransient<IOrganizationRepository, OrganizationRepository>();
            services.AddTransient<IPriorityRepository, PriorityRepository>();
            services.AddTransient<IRequestRepository, RequestRepository>();
            services.AddTransient<IRequestTypeRepository, RequestTypeRepository>();
            services.AddTransient<IResourceRequestRepository, ResourceRequestRepository>();
            services.AddTransient<IResourceRepository, ResourceRepository>();
            services.AddTransient<IResourceTypeRepository, ResourceTypeRepository>();
            services.AddTransient<ISectorRepository, SectorRepository>();
            services.AddTransient<IUnitRepository, UnitRepository>();

            // Enable MVC
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            // Enable swagger
            services.AddSwaggerGen(config =>
            {
                //config.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info()
                //{
                //    Title = "10Helmets APIs RESTful Central Management"
                //});

                config.SwaggerDoc("v1", new OpenApiInfo { Title = "10Helmets APIs RESTful Central Management", Version = "v1" });

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
                    config.ApiName = "cental-managemet-api";
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
                config.SwaggerEndpoint("../swagger/v1/swagger.json", "Backend API Central Management");
            });

            app.UseAuthentication();
            app.UseMvc();
        }
    }
}