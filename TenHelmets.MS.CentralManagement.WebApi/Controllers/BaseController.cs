﻿using TenHelmets.MS.Core.Enums;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;

namespace TenHelmets.MS.UI.CentralManagement.WebApi.Controllers
{
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class BaseController : ControllerBase
    {
        protected readonly IMapper _mapper;
        protected readonly IConfiguration _configuration;
        protected readonly IHostingEnvironment _environment;

        public BaseController(IConfiguration configuration,
            IMapper mapper,
            IHostingEnvironment environment)
        {
            this._mapper = mapper;
            this._environment = environment;
            this._configuration = configuration;
        }

        protected string GetConfigurationValue(string valueName)
        {
            return this._configuration.GetSection("AppSettings").GetSection(valueName).Value;
        }

        protected string GetMessage(int messageCode)
        {
            switch (messageCode)
            {
                case (int)Message.Correct:
                    return "Correcto";
                case (int)Message.RequestError:
                    return "Ha ocurrido un error en la llamada al API";
                case (int)Message.InternalError:
                    return "Ha ocurrido un error internp";
                case (int)Message.NullParameter:
                    return "Se envió un prámetro nulo al método";
                default:
                    throw new Exception("El código mensaje no corresponde a ninguno");
            }
        }

        protected void HandleException(string source,
            string description,
            string date)
        {
            //this._servicioLog.ErrorLogInsertar(strOrigen,
            //    strDescripcion,
            //    "0",
            //    this._configuracion.GetConnectionString("ISVConnectionString"));
        }
    }
}