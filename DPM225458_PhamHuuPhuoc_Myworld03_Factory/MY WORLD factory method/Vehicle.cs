using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myworld03_Factory
{

        public abstract class Vehicle
        {
            public List<string> Features = new List<string>();

            public void ShowFeatures()
            {
                Console.WriteLine(GetType().Name + " features:");
                foreach (var feature in Features)
                {
                    Console.WriteLine(" - " + feature);
                }
            }
        }

        // Concrete Products
        public class Car : Vehicle
        {
        }

        public class Bike : Vehicle
        {
        }

        public class Truck : Vehicle
        {
        }
    }

