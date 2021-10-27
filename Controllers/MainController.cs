using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace crud_cep.Controllers
{
    [ApiController]
    
    public class MainController : ControllerBase
    {
        [Route("/api/record")]
        public string Get() {
            return "o";
        }
    }
}
