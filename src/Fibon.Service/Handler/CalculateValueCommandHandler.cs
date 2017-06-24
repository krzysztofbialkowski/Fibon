using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fibon.Messages.Commands;
using Fibon.Messages.Events;
using Fibon.Tests;
using RawRabbit;

namespace Fibon.Service.Handler
{
    public class CalculateValueCommandHandler : ICommandHandler<CalculateValueCommand>
    {
        private readonly IBusClient _busClient;
        private readonly ICalculator _calculator;

        public CalculateValueCommandHandler(IBusClient busClient,ICalculator calculator)
        {
            _busClient = busClient;
            _calculator = calculator;
        }

        public async Task HandleAsync(CalculateValueCommand command)
        {
            int result = _calculator.DoYourJob(command.Number);
            await _busClient.PublishAsync(new ValueCalculatedEvent(command.Number, result));
        }
    }
}
