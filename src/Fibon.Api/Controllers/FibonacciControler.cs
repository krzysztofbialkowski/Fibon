using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RawRabbit;

namespace Fibon.Api.Controllers
{
    [Route("fibonacci")]
    public class FibonacciControler : Controller
    {

        private readonly IBusClient _iBusClient;

        public FibonacciControler(IBusClient busClient)
        {
            _iBusClient = busClient;
        }
        [HttpGet("{number}")]
        public async Task<IActionResult> Get(int number)
        {            
            return Content(number.ToString());
        }

        [HttpPost("{number}")]
        public async Task<IActionResult> Post(int number)
        {
            return Accepted($"fibonacci/{number}", null);
        }

    }
}
