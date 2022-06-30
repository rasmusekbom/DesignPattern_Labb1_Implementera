using Labb1_Implementera.Boats.Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera.Boats.Strategy
{
    class SpeedContext
    {
        private ISpeed Speed;

        public SpeedContext(ISpeed speed)
        {
            Speed = speed;
        }

        public void SetSpeedStrategy(ISpeed speed)
        {
            Speed = speed;
        }

        public string CreateSpeedBoat()
        {
            return Speed.ChosenSpeed();
        }
    }
}
