using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using crud_cep.Models;
using crud_cep.Data;

namespace crud_cep.Controllers
{
    [ApiController]
    
    public class MainController : ControllerBase
    {
        [Route("/api/record")]
        [HttpPost]
        public Task<ActionResponse> AddCep([FromBody] Cep cep) {
            return ManageCeps.AddCep(cep);
        }

        [Route("/api/record")]
        [HttpGet]
        public Task<Cep> AddCep(string cep) {
            return ManageCeps.RetrieveCep(cep);
        }
    }
}
