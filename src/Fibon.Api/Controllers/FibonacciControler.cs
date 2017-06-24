using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fibon.Api.Repository;
using Fibon.Messages.Commands;
using Microsoft.AspNetCore.Mvc;
using RawRabbit;

namespace Fibon.Api.Controllers
{
    [Route("fibonacci")]
    public class FibonacciControler : Controller
    {

        private readonly IBusClient _busClient;
        private readonly IRepository _repository;

        public FibonacciControler(IBusClient busClient,IRepository repository)
        {
            _busClient = busClient;
            _repository = repository;
        }
        [HttpGet("{number}")]
        public async Task<IActionResult> Get(int number)
        {
            int? inCache = _repository.Get(number);

            if (inCache.HasValue)
            {
                return Content(inCache.Value.ToString());
            }

            return NotFound();
        }

        [HttpPost("{number}")]
        public async Task<IActionResult> Post(int number)
        {
            int? inCache = _repository.Get(number);

            if (!inCache.HasValue)
            {
                await _busClient.PublishAsync(new CalculateValueCommand(number));
            }            
            return Accepted($"fibonacci/{number}", null);
        }
    }
}
