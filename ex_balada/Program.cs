using System;
namespace ex_balada
{
    class Program
    {
        static void Main(string[] args)
        {
            string r1;
            int r2;
            string r3;
            string r4;

            Console.WriteLine("   ---   ---   ---   ---\nSerá q voce consegue ir na balada? \n   ---   ---   ---   ---");
            Console.WriteLine("\nVocê tem disponibilidade para o dia da balada?");
            r1 = Console.ReadLine().ToLower();
            Console.WriteLine("\nQual a sua idade?");
            r2 = int.Parse(Console.ReadLine());
            
            if(r1.Equals("sim") && r2 >= 18){
                Console.WriteLine("\nTem o ingresso ou dinheiro para compra-lo?");
                r3 = Console.ReadLine().ToLower();
                if(r3.Equals("sim")){
                    Console.WriteLine("\nTa com pulseira VIP?");
                    r4 = Console.ReadLine().ToLower();
                    if(r4.Equals("sim")){
                        Console.WriteLine("\nVamo curtir de camarote entao!\n SEXTOU! \n Uhull!");
                    }
                    else if(r4.Equals("nao")){
                        Console.WriteLine("\nVamo curtir de pista entao!\n SEXTOU! \n Uhull!");
                    }
                    else{
                    Console.WriteLine("Erro 404\n Resposta inváida\n Reiniciando...");
                    }
                }   
                else if(r3.Equals("nao")){
                    Console.WriteLine("\nMoiou então! Você ta sem $$ :(");    
                }
                else{
                    Console.WriteLine("\nErro 404");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("\n Resposta inváida");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("\n Reiniciando...\n");
                    System.Threading.Thread.Sleep(1000);
                }
            }
            else{
                Console.WriteLine("\nMoiou então! Você é menor de idade ou não está disponivel para o dia da balada :(");
            }
        }
    }
}