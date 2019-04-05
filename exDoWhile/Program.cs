using System;

namespace exDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            bool jaAcordei = false;

            do{
                System.Console.WriteLine("Papi, ta acordado?");
                string resposta = Console.ReadLine().ToLower();
                
                jaAcordei = resposta.Contains("que") ? true : false;
            } while(!jaAcordei);

        }
    }
}
