using System;

namespace exIdade18
{
    class Program
    {
        static void Main(string[] args)
        {

            int resultado=0;
            for(int pessoa = 1; pessoa <10; pessoa++){
                System.Console.WriteLine("Insira a idade da pessoa {0}",pessoa);
                int idade = int.Parse(Console.ReadLine());
                if(idade >=18){
                    resultado++;
                }
            }
            System.Console.WriteLine("A quantidade de pessoas maior de idade é {0}.",resultado);
        }
    }
}
