using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
      
    
    class Program
    {
        static void Main(string[] args)
        {

            Samochod auto1 = new Samochod("Skoda",4.5);
            Console.WriteLine(auto1.ObliczSpalanie(200));
            Console.WriteLine(auto1.ObliczKosztPaliwa(200, 5));

            Console.ReadKey();


        }
    }
}
