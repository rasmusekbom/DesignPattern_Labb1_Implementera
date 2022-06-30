using Labb1_Implementera.Boats.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera.Boats.Factories.Interface
{
    public abstract class IBoatFactory
    {
        protected abstract IBoat MakeBoat();
        public IBoat CreateBoat()
        {
            return MakeBoat();
        }
    }
}
