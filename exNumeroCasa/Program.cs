using System;

namespace exNumeroCasa
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[4];
            for (int j = 0; j < num.Length; j++)
            {
                System.Console.Write("Insira o número da {0}ª casa: ",(j+1));
                num[j] = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine();
            for (int i = 0; i < num.Length; i++){ 
                System.Console.WriteLine("O número da {0}ª casa é {1}",(i+1),num[i]);
            }
            System.Console.WriteLine("\nOs numeros inseridos foram:");
            foreach (var numIndv in num)
            {
                System.Console.Write("{0}, ",numIndv);
            }
        }
    }
}
