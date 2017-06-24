using System;
using System.Collections.Generic;
using System.Text;

namespace Fibon.Messages.Commands
{
    public class CalculateValueCommand : ICommand
    {

        protected CalculateValueCommand()
        {
            
        }

        public CalculateValueCommand(int number)
        {
            Number = number;
        }

        public int Number { get; private set; }
    }
}
