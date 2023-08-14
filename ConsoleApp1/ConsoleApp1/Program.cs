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
            // float (real)


            float numero1;
            float numero2;
            float numero3;
            float numero4;
            float soma;
            float subtracao;
            float divisao;
            float multiplicacao;



            Console.Write("digite um numero: ");

            numero1 = float.Parse (Console.ReadLine());

            Console.Write("digite o segundo numero: ");

            numero2 = float.Parse (Console.ReadLine());

            Console.Write("digite o terceiro numero: ");

            numero3 = float.Parse(Console.ReadLine());

            Console.Write("digite o quarto numero: ");

            numero4 = float.Parse(Console.ReadLine());



            Console.WriteLine(" ");



            Console.WriteLine("o primeiro valor digitado foi: " + numero1);
            
            Console.WriteLine("o segundo valor digitado foi: " + numero2);
  
            Console.WriteLine("o terceiro valor digitado foi: " + numero3);

            Console.WriteLine("o quarto valor digitado foi: " + numero4);


            Console.WriteLine(" ");

    
            soma = numero1 + numero2 + numero3 + numero4;  

            subtracao = numero1 - numero2 - numero3 - numero4;

            multiplicacao = numero1 * numero2 * numero3 + numero4;

            divisao = numero1 / numero2 / numero3 / numero4;


            Console.WriteLine("o resultado da divisao foi: " + divisao);

            Console.WriteLine(" ");

            Console.WriteLine("o resultado da soma foi: " + soma);

            Console.WriteLine(" ");

            Console.WriteLine("o resultado da multiplicacao foi: " + multiplicacao);

            Console.WriteLine(" ");

            Console.WriteLine("o resultado da subtracao foi: " + subtracao);


            Console.ReadKey();
        }
    }
}
