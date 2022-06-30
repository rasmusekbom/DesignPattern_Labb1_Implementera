using Labb1_Implementera.Boats.Models.Interface;
using Labb1_Implementera.Boats.Strategy;
using Labb1_Implementera.Boats.Strategy.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera.Boats.Models
{
    class Yacht : IBoat
    {
        public string Speed { get; set; }

        public Yacht()
        {
            Speed = runmenu(); // Prints the menu with the Strategy-options and where to set up your new boat.
        }

        public string GetSpeedTypeOfBoat()
        {
            return Speed;
        }

        public static string runmenu()
        {
            bool run = true;

            Console.WriteLine("Would you want a slow, medium or highspeed yacht?" +
                "\nPlease choose with the correct number followed by Enter."
                + "\n1) Slow Speed Boat" +
                "\n2) Medium Speed Boat" +
                "\n3) High Speed Boat");

            try
            {
                while (run)
                {
                    string SpeedChoice = Console.ReadLine();

                    if (SpeedChoice == "1")
                    {
                        SpeedContext speedtype = new SpeedContext(new SlowSpeed());
                        var setSpeed = speedtype.CreateSpeedBoat();
                        return setSpeed;
                    }
                    else if (SpeedChoice == "2")
                    {
                        SpeedContext speedtype = new SpeedContext(new MediumSpeed());
                        var setSpeed = speedtype.CreateSpeedBoat();
                        return setSpeed;
                    }
                    else if (SpeedChoice == "3")
                    {
                        SpeedContext speedtype = new SpeedContext(new HighSpeed());
                        var setSpeed = speedtype.CreateSpeedBoat();
                        return setSpeed;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong, please try again.");
            }
            return null;
        }
    }
}
