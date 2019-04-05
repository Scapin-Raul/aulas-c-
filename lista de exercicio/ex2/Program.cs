using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano;
            Console.WriteLine("\nSerá que você poderá votar nas eleições de 2020?\nInsira seu ano de nascimento:");
            ano = int.Parse(Console.ReadLine());
            if(ano <= 2002){
                Console.WriteLine("\nVocê pode votar!\n Só lembre-se,\n PT é 13! Taokey");
            }
            else if(ano > 2002 && ano <= 2004){
                Console.WriteLine("\nSinto muito, você nao poderá votar em 2020.\nEntretanto em 2022 você poderá!");
            }
            else if(ano > 2004){
                Console.WriteLine("\nSinto muito, mas você nao poderá votar! Nem em 2020 e 2022.");
            }
            else{
                Console.WriteLine("\nResposta inválida\nEncerrando processo...");
            }
        }
    }
}
