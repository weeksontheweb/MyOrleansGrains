﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOrleansGrainInterfaces
{
    public interface IHello : IGrainWithIntegerKey
    {
        ValueTask<string> SayHello(string greeting);
    }
}
