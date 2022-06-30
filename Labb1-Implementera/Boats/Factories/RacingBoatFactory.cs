using Labb1_Implementera.Boats.Factories.Interface;
using Labb1_Implementera.Boats.Models;
using Labb1_Implementera.Boats.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera.Boats.Factories
{
    public class RacingBoatFactory : IBoatFactory
    {
        protected override IBoat MakeBoat()
        {
            IBoat boat = new RacingBoat();
            return boat;
        }
    }
}
