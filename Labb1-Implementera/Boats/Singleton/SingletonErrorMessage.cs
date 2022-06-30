using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera.Boats.Singleton
{
    public sealed class SingletonErrorLog
    {
        private static SingletonErrorLog instance = null;
        public static SingletonErrorLog GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new SingletonErrorLog();
                return instance;
            }
        }

        public void WrongInputMessage()
        {
            Console.WriteLine("Wrong input, try again.");
        }
    }
}
