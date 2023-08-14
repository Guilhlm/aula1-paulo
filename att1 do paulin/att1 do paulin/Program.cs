using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace att1_do_paulin
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double a, b, c;
            double divisao;
            double soma;


            Console.WriteLine("digite um numero: ");

                a = int.Parse(Console.ReadLine());

            Console.WriteLine();


            Console.WriteLine("digite um segundo numero: ");

                b = int.Parse(Console.ReadLine());  

            Console.WriteLine();


            Console.WriteLine("digite um terceiro numero: ");

                c = int.Parse(Console.ReadLine());

            Console.WriteLine();




                soma = a + b + c;

                divisao = soma / 3;


            Console.WriteLine("O sua resultado eh igual a: " + soma);

            Console.WriteLine();

            Console.WriteLine("A sua media eh igual a: " + divisao);



            Console.ReadKey();
        }
    }
}
