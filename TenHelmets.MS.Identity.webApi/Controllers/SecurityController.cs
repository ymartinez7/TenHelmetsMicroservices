using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityModel.Client;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TenHelmets.MS.Identity.webApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SecurityController : ControllerBase
    {
        //[HttpGet]
        //public async Task<IActionResult> GetTokenAsync(string client, string secret)
        //{
        //    var discovery = await DiscoveryClient.GetAsync("http://localhost:5000");
        //    var tokenClient = new TokenClient(discovery.TokenEndpoint, client, secret);
        //    //var tokenResponse = await TokenClient.RequestClientCredentialAsync("administration-api");

        //    return Ok(tokenResponse);
        //}
    }
}