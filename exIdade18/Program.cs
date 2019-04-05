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


            // Console.WriteLine("Insira a idade da 1ª pessoa:");
            // int pessoa1 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Insira a idade da 2ª pessoa:");
            // int pessoa2 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Insira a idade da 3ª pessoa:");
            // int pessoa3 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Insira a idade da 4ª pessoa:");
            // int pessoa4 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Insira a idade da 5ª pessoa:");
            // int pessoa5 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Insira a idade da 6ª pessoa:");
            // int pessoa6 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Insira a idade da 7ª pessoa:");
            // int pessoa7 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Insira a idade da 8ª pessoa:");
            // int pessoa8 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Insira a idade da 9ª pessoa:");
            // int pessoa9 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Insira a idade da 10ª pessoa:");
            // int pessoa10 = int.Parse(Console.ReadLine());

            // string resultado ="";
            
            // if(pessoa1 >=18){
            //     resultado+=" 1ª pessoa:"+pessoa1;
            // }
            // if(pessoa2 >=18){
            //     resultado+=" 2ª pessoa:"+pessoa2;
            // }
            // if(pessoa3 >=18){
            //     resultado+=" 3ª pessoa:"+pessoa3;
            // }
            // if(pessoa4 >=18){
            //     resultado+=" 4ª pessoa:"+pessoa4;
            // }
            // if(pessoa5>=18){
            //     resultado+=" 5ª pessoa:"+pessoa5;
            // }
            // if(pessoa6 >=18){
            //     resultado+=" 6ª pessoa:"+pessoa6;
            // }
            // if(pessoa7 >=18){
            //     resultado+=" 7ª pessoa:"+pessoa7;
            // }
            // if(pessoa8 >=18){
            //     resultado+=" 8ª pessoa:"+pessoa8;
            // }
            // if(pessoa9>=18){
            //     resultado+=" 9ª pessoa:"+pessoa9;
            // }
            // if(pessoa10 >=18){
            //     resultado+=" 10ª pessoa:"+pessoa10;
            // }
            // Console.WriteLine("As pessoas maiores de idade sao:\n {0}",resultado);
        }
    }
}
