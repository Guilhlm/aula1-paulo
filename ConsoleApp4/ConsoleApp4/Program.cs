using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double a, b, resultado;

            Console.WriteLine("digite um numero: ");
            
            a = int.Parse(Console.ReadLine());

           
            resultado = Math.Pow(a, 2);

            Console.WriteLine("o resultado = " + resultado);


            Console.WriteLine("digite um outro numero ");

            b = int.Parse(Console.ReadLine());


            resultado = Math.Sqrt(b);

            Console.WriteLine("o resultado = " + resultado);




            Console.ReadKey();
        }
    }
}
