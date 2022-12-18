using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace TaxApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> GetTaxList()
        {
            return new List<string>() {"tax1", "tax2"};
        }
        [HttpGet("tax1")]
        public IEnumerable<string> GetTax1()
        {
            return new List<string>() { "tax1 info.." };
        }
    }
}
