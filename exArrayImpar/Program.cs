using System;

namespace exArrayImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[15];
            int impar =0;
            for (int j = 0; j < 15; j++)
            {
                System.Console.Write("Insira o {0}º número: ",(j+1));
                num[j] = int.Parse(Console.ReadLine());
                if( (num[j]%2) != 0){
                    impar++;
                }
            }
            System.Console.WriteLine("O total de numeros impares é {0}.",impar);
            for (int i = 0; i < 15; i++){ 
                System.Console.Write(num[i]+", ");}
        }
    }
}
