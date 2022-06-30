using Labb1_Implementera.Boats.Factories;
using Labb1_Implementera.Boats.Models.Interface;
using Labb1_Implementera.Boats.Singleton;
using System;
using System.Collections.Generic;

namespace Labb1_Implementera
{
    internal class Program
    {
        // Jag har valt designmönstrena : Factory Method, Singleton samt Strategy.
        // Rasmus Ekbom, .NET21 - 2022
        // Designmönster & Arkitektur

        public static List<IBoat> boatList = new List<IBoat>();

        static void Main(string[] args)
        {
            bool run = true;

            Console.WriteLine("Hello Boatlovers! Please create your own original boat by choosing by the visible alternatives followed by Enter.");

            while (run)
            {
                Console.WriteLine("1) Create a Fishing Boat" +
                    "\n2) Create a Racing Boat" +
                    "\n3) Create a Yacht" +
                    "\n4) Print out all your current orders." +
                    "\n\n5) Quit the application.");

                string userChoice = Console.ReadLine();

                // Användaren skapar en Fishing Boat
                if (userChoice == "1")
                {
                    Console.Clear();
                    IBoat boat = new FishingBoatFactory().CreateBoat();
                    boatList.Add(boat);
                    Console.WriteLine("Fishing Boat created! Enjoy your fishing!");
                }

                // Användaren skapar en Racing Boat
                else if (userChoice == "2")
                {
                    Console.Clear();
                    IBoat boat = new RacingBoatFactory().CreateBoat();
                    boatList.Add(boat);
                    Console.WriteLine("Racing Boat created! Enjoy your racing!");
                }

                // Användaren skapar en Yacht
                else if (userChoice == "3")
                {
                    Console.Clear();
                    IBoat boat = new YachtFactory().CreateBoat();
                    boatList.Add(boat);
                    Console.WriteLine("Yacht created! Enjoy your cruising around the world!");
                }

                // Användaren får se alla sina båtar
                else if (userChoice == "4")
                {
                    Console.Clear();
                    
                    if (boatList != null)
                    {
                        foreach (var item in boatList)
                        {
                            var boatName = item.GetType();
                            Console.WriteLine("Type of Boat: " + boatName.Name + "Speed type: " + item.GetSpeedTypeOfBoat().ToString());
                        }
                    }
                }

                // Användaren avslutar applikationen.
                else if (userChoice == "5")
                {
                    Environment.Exit(0);
                }


                // Här används Singleton för att printa ett Error-meddelande ifall man ej följer menyn korrekt.
                else
                {
                    Console.Clear();
                    SingletonErrorLog errorMessage = SingletonErrorLog.GetInstance;
                    errorMessage.WrongInputMessage();
                }
            }
        }
    }
}
