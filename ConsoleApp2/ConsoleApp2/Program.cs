using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int valor1;
            int valor2;
            int soma;
            


            Console.WriteLine("escreva o primeiro numero: ");

            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("escreva o segundo valor: ");

            valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("o primeiro numero digitado foi: " + valor1);    

            Console.WriteLine("");

            Console.WriteLine("o segundo numero digitado foi: " + valor2);

            Console.WriteLine("");

            Console.WriteLine("a soma dos dois valores eh: " + soma);

            soma = valor1 + valor2; 

            Console.ReadKey();
        }
    }
}
