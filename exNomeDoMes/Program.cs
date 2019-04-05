using System;

namespace exNomeDoMes
{
    class Program
    {
        static void Main(string[] args)
        {
            // int num = 1;
            // while (num != 0){
            //     Console.WriteLine("Digite o numero do mês ou 0 para sair:");
            //     num = int.Parse(Console.ReadLine());
            //         switch (num){
            //         case 1:
            //         Console.WriteLine("Janeiro");
            //         break;

            //         case 2:
            //         Console.WriteLine("Fevereiro");
            //         break;

            //         case 3:
            //         Console.WriteLine("Março");
            //         break;

            //         case 4:
            //         Console.WriteLine("Abril");
            //         break;
                    
            //         case 5:
            //         Console.WriteLine("Maio");
            //         break;

            //         default:
            //         Console.WriteLine("o foco é o golpe");
            //         break;
            //     }
            // }

            bool usuarioAindaQuerJogar= true;
            int cont = 3;

            while (cont != 0 && usuarioAindaQuerJogar){
                Console.WriteLine("quieres jugar? Ainda restam {0} tentativas", cont);
                string resposta = Console.ReadLine();
                usuarioAindaQuerJogar = resposta.Equals("sim") ? true : false;
                cont--;
            }



        }
    }
}
