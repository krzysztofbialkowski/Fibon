﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Fibon.Tests
{
    public interface ICalculator
    {
        int DoYourJob(int number);
    }


    public class SlowOne : ICalculator
    {
        public int DoYourJob(int number)
        {

            switch (number)
            {
                case 0:
                    return 0;
                case 1:
                    return 1;
                default:
                    return DoYourJob(number - 2) + DoYourJob(number - 1);
            }

        }
    }
}
