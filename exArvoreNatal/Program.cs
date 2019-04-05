using System;

namespace exArvoreNatal
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura = 8;
            int colunas =8;
            string estrela = "";
            for (int i = 0; i <= altura; i++) {
                estrela = "";
                for (int j = 0; j <= colunas; j++)
                {
                    // System.Console.WriteLine($"[{i},{j}]");
                    estrela+="*";
                    System.Console.WriteLine(estrela);
                    System.Threading.Thread.Sleep(75);
                }
                
            }
        }
    }
}
