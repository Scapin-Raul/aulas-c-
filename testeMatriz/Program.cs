using System;

namespace testeMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = {
                                {1,2,3},
                                {4,5,6},
                                {7,8,9}
            };
            int soma = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    soma +=matriz[i,j];
                }
            }
        System.Console.WriteLine(soma);
        }
    }
}

            // for (int i = 0; i < 10; i++)
            // {
                
            //     for (int j = 0; j < matriz.GetLength(i); j++)
            //     {
            //     matriz[i,j] = $"{i}{j}";
            //     System.Console.WriteLine(matriz[i,j]);
            //     System.Threading.Thread.Sleep(25);    
            //     }
            // }