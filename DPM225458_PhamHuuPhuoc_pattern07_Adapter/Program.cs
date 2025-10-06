using System;
namespace DPM225458_PhamHuuPhuoc_pattern07_Adapter
{

    public class Program
    {
        public static void Main(string[] args)
        {
            // Create adapter and place a request
            Target target = new Adapter();
            target.Request();
            // Wait for user
            Console.ReadKey();
        }
    }
}