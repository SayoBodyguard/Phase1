﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCartographyObjects
{
    interface IIsPointClose
    {
        bool IsPointClose(double Xparam, double Yparam, double preci);
    }
}
