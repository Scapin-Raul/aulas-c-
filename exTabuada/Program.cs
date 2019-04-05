using System;

namespace exTabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            bool querJogar = true;
            int num = 1;
            int mult = 1;

            while(querJogar){
                if(mult==1){
                    Console.Write("Digite a tabuada que você quer saber: ");
                    num = int.Parse(Console.ReadLine());
                    System.Console.WriteLine();
                }
                
                Console.WriteLine(num+"x"+mult+"="+(num*mult)+"     "+num+"x"+(mult+1)+"="+(num*(mult+1)));
                // mult++; mult++;
                mult += 2;
                
                if(mult >10){
                    Console.WriteLine("\nVocê quer saber outra tabuada?");
                    string resposta = Console.ReadLine();
                    mult = 1;
                    querJogar = resposta.Equals("sim") ? true : false;
                } //fim if
            } //fim while
        }
    }
}
