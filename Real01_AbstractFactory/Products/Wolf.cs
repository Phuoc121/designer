using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real01_AbstractFactory.Products
{
    public class Wolf : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            Console.WriteLine($"{GetType().Name} eats {h.GetType().Name}");
        }
    }
}
