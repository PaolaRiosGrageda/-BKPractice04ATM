﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLEvel1.Practice04
{
    public class NotMultipleOfTenException : Exception
    {
        public NotMultipleOfTenException(): base("The account can only receive multiples of 10")
        {
           

        }
    }
}
