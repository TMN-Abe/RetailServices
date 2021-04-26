using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RetailServices.Controllers
{
    public class CorporateController : ControllerBase
    {
        HttpClient _client;
        public CorporateController(HttpClient client)
        {
            _client = client;
        }


        [HttpPost("addcoporate")]
        public async Task AddCoporate(string coporateCd)
        {


        }

    }
}
