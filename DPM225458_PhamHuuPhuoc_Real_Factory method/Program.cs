using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
namespace DPM225458_PhamHuuPhuoc_Real_Factory_method
{
  
    class MainApp
    {
      
        static void Main()
        {
          
            Document[] documents = new Document[2];
            documents[0] = new Resume();
            documents[1] = new Report();
           
            foreach (Document document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }
            
            Console.ReadKey();
        }
    }
}
