using System;

namespace primeiro_aplicativo
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string sobrenome;

            Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-");
            Console.WriteLine("Bem vindo!");
            Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-");
            Console.WriteLine("Digite seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu sobrenome:");
            sobrenome = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Bem vindo senhor(a) "+nome+" "+sobrenome);
            Console.WriteLine("");
        }
    }
}
