using System;

namespace previsao_tempo
{
    class Program
    {
        static void Main(string[] args)
        {
            string previsao;
            string resposta;

            Console.WriteLine("");
            Console.WriteLine("Analista de previsao do tempo!");
            Console.WriteLine("---   ---   ---   ---   ---   ---");
            Console.WriteLine("Insira a previsao do tempo:");
            previsao = Console.ReadLine().ToLower();
            Console.WriteLine("");

            if(previsao.Equals("frio")){
                Console.WriteLine("Vamos à montanha!");
            }
            else if(previsao.Equals("calor")){
                Console.WriteLine("Vamos à praia!");
            }
            else if(previsao.Equals("chuva")){
                Console.WriteLine("Vamos à Steam?");
                resposta = Console.ReadLine().ToLower();
                if(resposta.Equals("sim")){
                    Console.WriteLine("Entao bora!");
                }
                else if (resposta.Equals("nao")){
                    Console.WriteLine("Vamos ao Netflix!");
                }
            }
            else{
                Console.WriteLine("Previsao do tempo invalido");
            }
            


        }
    }
}
