using System;

namespace Aula12
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
           int anoNasc;
            int anoAtual = 2020;
           
            Console.Write("Digite seu Nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite o ano que Você nasceu: ");
            anoNasc = int.Parse(Console.ReadLine());
            anoNasc= anoAtual - anoNasc;
            
            if (anoNasc >= 18)
            {

                Console.WriteLine("Ola {0} , você tem {1} anos , e você e maior de idade", nome, anoNasc);
            }
            else {
                Console.WriteLine("Ola {0} , você tem {1} anos , e você e menoo de idade ", nome, anoNasc);
               }

            Console.ReadKey();
        }
    }
}
