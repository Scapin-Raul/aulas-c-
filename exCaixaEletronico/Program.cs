using System;

namespace exCaixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("BEM VINDO AO CAIXA ELETRONICO TALKEY!");
            int[] qntNotas = new int[7];
            int[] notas = {100, 50, 20, 10, 5, 2, 1};
            int saque;
            DateTime data = DateTime.Now;
            do{
                System.Console.Write("Insira o valor do saque: ");
                saque = int.Parse(Console.ReadLine());
            } while (saque < 0);
            System.Console.WriteLine("\nVocê recebeu:");

            for (int j = 0; j < notas.Length; j++){ 
                qntNotas[j] = saque / notas[j];
                saque = saque % notas[j];  
                if (qntNotas[j]>0){
                    System.Threading.Thread.Sleep(qntNotas[j]*50);
                    System.Console.WriteLine("{0} nota(s) de R$ {1},00.",qntNotas[j],notas[j]);
                }//fim if
            } //fim for
        }
    }
}