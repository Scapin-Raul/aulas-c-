using System;

namespace exArvoreNatal
{
    class Program
    {
        static void Main(string[] args)
        {
            string estrela = "";
            System.Console.WriteLine("Escolha a quantidade de altura e de colunas, respectivamente:");
            int altura = int.Parse(Console.ReadLine());
            int colunas = int.Parse(Console.ReadLine());
            for (int i = 1; i <= altura; i++) {
                estrela = "";
                for (int j = 1; j <= colunas; j++)
                {
                    estrela+="*";
                    System.Console.WriteLine(estrela);
                    System.Threading.Thread.Sleep(50);
                } // fim for interno
            }//fim for externo
        }
    }
}
