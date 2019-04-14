using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        
        {           string resposta;
                    System.Console.WriteLine();
                    // System.Console.WriteLine("Bem vindo ao pedidor de namoro.");
                    System.Console.WriteLine("Para que o programa possa ser inicializado com eficiencia");
                    System.Console.Write("Insira seu nome: ");
                    string nome = Console.ReadLine();
                    System.Console.WriteLine();
                    System.Console.Write($"Olá {nome}. ");
                    System.Threading.Thread.Sleep(500);
                    System.Console.Write("Será que você não quer namorar o ");
                    System.Console.Write("R");
                    System.Threading.Thread.Sleep(100);
                    System.Console.Write("a");
                    System.Threading.Thread.Sleep(100);
                    System.Console.Write("u");
                    System.Threading.Thread.Sleep(100);
                    System.Console.Write("l");
                    System.Threading.Thread.Sleep(100);
                    System.Console.Write("zi");
                    System.Threading.Thread.Sleep(100);
                    System.Console.Write("nho");
                    System.Threading.Thread.Sleep(500);
                    System.Console.WriteLine("?");
                    System.Threading.Thread.Sleep(1000);
                    do
                    {
                        System.Console.WriteLine($"\nDigite a resposta? (sim ou nao)");
                        resposta = Console.ReadLine();  
                    } while (!"sim".Equals(resposta)&&!"nao".Equals(resposta));
                    if (resposta.Equals("sim")){
                        System.Console.WriteLine("");
                        System.Console.WriteLine("     ****   ****");
                        System.Threading.Thread.Sleep(300);
                        System.Console.WriteLine("    *    * *    *");
                        System.Threading.Thread.Sleep(300);
                        System.Console.WriteLine("   *     * *     *");
                        System.Threading.Thread.Sleep(300);
                        System.Console.WriteLine("  *       *       *");
                        System.Threading.Thread.Sleep(300);
                        System.Console.WriteLine(" *     Parabens    *");
                        System.Threading.Thread.Sleep(300);
                        System.Console.WriteLine("  *     agora     *");
                        System.Threading.Thread.Sleep(300);
                        System.Console.WriteLine("   *   você me   *");
                        System.Threading.Thread.Sleep(300);
                        System.Console.WriteLine("     *  namora *");
                        System.Threading.Thread.Sleep(300);
                        System.Console.WriteLine("      *  kkk  *");
                        System.Threading.Thread.Sleep(300);
                        System.Console.WriteLine("        *   *");
                        System.Threading.Thread.Sleep(300);
                        System.Console.WriteLine("         * *");
                        System.Threading.Thread.Sleep(300);
                        System.Console.WriteLine("          *");
                        System.Threading.Thread.Sleep(1000);
                        System.Console.WriteLine("\nPrograma feito by: Vakkuzinho");
                    }else
                    {
                        System.Console.WriteLine("Hum, que pena, mas tudo bem!");
                        System.Console.WriteLine("\nPrograma feito by: Vakkuzinho");
                    }
        }
    }
}
