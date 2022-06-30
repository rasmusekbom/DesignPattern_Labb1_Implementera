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
    public class FishingBoatFactory : IBoatFactory
    {
        protected override IBoat MakeBoat()
        {
            IBoat boat = new FishingBoat();
            return boat;
        }
    }
}
