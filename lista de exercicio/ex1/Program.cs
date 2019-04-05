using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;
            Console.WriteLine("COMPARADOR DE NUMEROS QUANTICO!\n");
            Console.WriteLine("Insira o primeiro numero!\n");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo numero!\n");
            n2 = int.Parse(Console.ReadLine());

            if(n1 == n2){
                Console.WriteLine("Os numeros nao podem ser iguais.\nFinalizando processo...");
                System.Threading.Thread.Sleep(1000);
            }
            else if(n1 > n2){
                Console.Write("Comparando dados");
                System.Threading.Thread.Sleep(300);
                Console.Write(".");
                System.Threading.Thread.Sleep(400);
                Console.Write(".");
                System.Threading.Thread.Sleep(400);
                Console.WriteLine(".");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("O maior numero inserido foi: "+n1);
            }
            else if(n1 < n2){
                Console.Write("Comparando dados");
                System.Threading.Thread.Sleep(300);
                Console.Write(".");
                System.Threading.Thread.Sleep(400);
                Console.Write(".");
                System.Threading.Thread.Sleep(400);
                Console.WriteLine(".");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("O maior numero inserido foi: "+n2);
            }         

        }
    }
}
