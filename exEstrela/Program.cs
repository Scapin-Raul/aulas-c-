using System;

namespace exEstrela
{
    class Program
    {
        static void Main(string[] args)
        {
            string asterisco = "";
            Console.WriteLine("Insira a quantidade de estrelas que você quer na base do triangulo!");
            int numeroBase = int.Parse(Console.ReadLine());
            System.Console.WriteLine();

            for(int i =0; i<numeroBase; i++){
                asterisco+="*";
                System.Console.WriteLine(asterisco);
                System.Threading.Thread.Sleep(75);
            }
        }
    }
}
