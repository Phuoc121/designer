using System;
namespace DPM225458_PhamHuuPhuoc_pattern04_Factory_Method
{

    class MainApp
    {

        static void Main()
        {

            Creator[] creators = new Creator[2];
            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();

            foreach (Creator creator in creators)
            {
                Product product = creator.FactoryMethod();
                Console.WriteLine("Created {0}",
                  product.GetType().Name);
            }

            Console.ReadKey();
        }
    }
}
