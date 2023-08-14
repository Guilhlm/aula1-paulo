using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att2_paulin
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int nota;
            int preco;
            int troco;
            
           

            Console.WriteLine("digite qual o valor do produto escolhido");

                preco = int.Parse(Console.ReadLine());

            Console.WriteLine();


            Console.WriteLine("escreva qual a sua nota: ");

                nota = int.Parse(Console.ReadLine());


            Console.WriteLine();


                troco = nota - preco;


            if (preco > nota)
            {

                Console.WriteLine("o senhor nao possui dinheiro suficiente");
            } else 
            {

                Console.WriteLine("compra realizada com sucesso seu troco eh de :" + troco);

            }




            Console.ReadKey();
        }
    }
}
