using System;
namespace DPM225458_PhamHuuPhuoc_Facade10_Real
{


    public class Program
    {
        public static void Main(string[] args)
        {
            Facade facade = new Facade();
            facade.MethodA();
            facade.MethodB();
           
            Console.ReadKey();
        }
    }
}
