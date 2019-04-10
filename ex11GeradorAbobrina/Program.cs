using System;

namespace ex11GeradorAbobrina
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("manda uma palavra ai, meu fidalgo!");

            int maxPalavrasUsuario = 5;
            int maxPalavrasFras = 8;

            string[] palavrasUsuario = new string [maxPalavrasUsuario];

            for (int i = 0; maxPalavrasUsuario > 0 ; i++)
            {
                palavrasUsuario[i] = Console.ReadLine();
                if(--maxPalavrasUsuario != 0){
                    System.Console.WriteLine($"Faltam {maxPalavrasUsuario}. Digite mais uma!");
                }else{
                    System.Console.WriteLine("Enos");
                }
            }

        }
    }
}
