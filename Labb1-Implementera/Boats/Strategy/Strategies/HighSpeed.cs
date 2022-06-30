using Labb1_Implementera.Boats.Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera.Boats.Strategy.Strategies
{
    class HighSpeed : ISpeed
    {
        public string ChosenSpeed()
        {
            return "High Speed";
        }
    }
}
