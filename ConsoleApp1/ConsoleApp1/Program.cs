using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("hello world");
            //Console.ReadLine();

            // string (cadeia)
            // int (inteiro)
            // flowt (real)


            int numero1;
            int numero2;
            int numero3;
            int numero4;
            int soma;




            Console.Write("digite um numero: ");

            numero1 = int.Parse (Console.ReadLine());

            Console.Write("digite o segundo numero: ");

            numero2 = int.Parse (Console.ReadLine());

            Console.Write("digite o terceiro numero: ");

            numero3 = int.Parse(Console.ReadLine());

            Console.Write("digite o quarto numero: ");

            numero4 = int.Parse(Console.ReadLine());



            Console.WriteLine(" ");



            Console.WriteLine("o valor digitado foi: " + numero1);

            Console.WriteLine(" ");
            
            Console.WriteLine("o valor digitado foi: " + numero2);

            Console.WriteLine(" ");

            Console.WriteLine("o valor digitado foi: " + numero3);

            Console.WriteLine(" ");

            Console.WriteLine("o valor digitado foi: " + numero4);

            Console.WriteLine(" ");


            soma = numero1 + numero2 + numero3 + numero4;  
            
            
            Console.WriteLine("o valor total foi: " + soma);




           Console.ReadKey();
        }
    }
}
