using System;
using System.Collections.Generic;
using System.Text;

namespace Fibon.Messages.Events
{
    public class ValueCalculatedEvent:IEvent
    {

        public ValueCalculatedEvent(int number,int result)
        {
            Number = number;
            Result = result;
        }

        public int Number { get; private set; }
        public int Result { get; private set; }

    }
}
