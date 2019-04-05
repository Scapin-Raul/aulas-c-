using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.Sleep(50);
            Console.Write("Para");
            System.Threading.Thread.Sleep(50);
            Console.Write(" fazer");
            System.Threading.Thread.Sleep(50);
            Console.Write(" login,");
            System.Threading.Thread.Sleep(50);
            Console.Write(" insira");
            System.Threading.Thread.Sleep(50);
            Console.Write(" sua");
            System.Threading.Thread.Sleep(50);
            Console.WriteLine(" senha:");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("DICA: 4321");

            int senha = int.Parse(Console.ReadLine());
            if(senha == 1234){
                System.Threading.Thread.Sleep(50);
                Console.Write("Acesso");
                System.Threading.Thread.Sleep(50);
                Console.Write(" autorizado!");
            }
            else{
                System.Threading.Thread.Sleep(50);
                Console.Write("Acesso");
                System.Threading.Thread.Sleep(50);
                Console.WriteLine(" negado!");
                System.Threading.Thread.Sleep(50);
                Console.Write("Seu");
                System.Threading.Thread.Sleep(50);
                Console.Write(" hackerzinho");
                System.Threading.Thread.Sleep(50);
                Console.Write(" meia");
                System.Threading.Thread.Sleep(50);
                Console.Write(" boca!");
            }
        }
    }
}
