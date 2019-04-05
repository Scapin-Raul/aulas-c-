using System;

namespace exContador
{
    class Program
    {
        static void Main(string[] args)
        {
           int cont = 0;
           System.Console.WriteLine("Bem vindo ao contador!");
           System.Console.WriteLine("Insira o numero que você quer somar até 500");
           int soma = int.Parse(Console.ReadLine());
           do{
               System.Console.WriteLine("O valor atual do contador é de: {0}",cont);
                cont+=soma;
                System.Threading.Thread.Sleep(100);
           } while(cont<=500);

        }
    }
}
