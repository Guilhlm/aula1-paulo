using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att3_paulin
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double celcius, fa;
           


            Console.WriteLine("digite a temperatura em graus celcius : ");

              celcius = int.Parse(Console.ReadLine());

            Console.WriteLine();



               fa = (celcius * 9 / 5) + 32;


           Console.WriteLine("a temperatura e fahren eh: " + fa);

            








            Console.ReadKey();
        }
    }
}
