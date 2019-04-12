using System;

namespace ex11GeradorAbobrina
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva uma frase dando enter entre as palavras, meu patriota!");

            int maxPalavrasUsuario = 5;
            int maxPalavrasFrase = 5;

            string[] palavrasUsuario = new string [maxPalavrasUsuario];

            for (int i = 0; maxPalavrasUsuario > 0 ; i++)
            {
                palavrasUsuario[i] = Console.ReadLine();
                if(--maxPalavrasUsuario != 0){
                    System.Console.WriteLine($"Faltam {maxPalavrasUsuario}. Digite mais uma!");
                }else{
                    System.Console.WriteLine("É isso");
                }
            }

        string[,] matrizPalavras = {    {"eu","ela","minha avó","o diego",""},
                                        {"comi","é","escreveu","saiu",""},
                                        {"batata","uma pessoa","um","para",""},
                                        {"ontem","bem","poema","o bar",""},
                                        {"á noite","batuta","top","beber",""}
        };
        for (int i = 0; i < matrizPalavras.GetLength (0); i++){
            for (int j = 0; j < matrizPalavras.GetLength (0); j++){
                if("".Equals(matrizPalavras[i,j])) {
                    matrizPalavras[i,j] = palavrasUsuario[i];
                }
            }
        }

        string frase ="";

        Random r = new Random();
        for (int i = 0; i < maxPalavrasFrase; i++){
            frase += matrizPalavras[i,r.Next(matrizPalavras.GetLength(0))] + " ";  //j
        }
        System.Console.WriteLine("Minha frase é:\n"+frase);

        }//end main
    }
}