﻿using Labb1_Implementera.Boats.Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera.Boats.Strategy.Strategies
{
    class SlowSpeed : ISpeed
    {
        public string ChosenSpeed()
        {
            return "Slow Speed";
        }
    }
}
