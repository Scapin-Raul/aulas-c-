using System;

namespace exCaixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("BEM VINDO AO CAIXA ELETRONICO TALKEY!\n");
            int[] qntNotas = new int[7];
            int[] notas = {100, 50, 20, 10, 5, 2, 1};
            System.Console.WriteLine("Insira o valor do saque:");
            int saque = int.Parse(Console.ReadLine());
            
            for (int j = 0; j < notas.Length; j++)
            {
                if (saque >= notas[j])
                {
                    saque = saque - notas[j];
                    qntNotas[j]++;
                }
            }

            System.Console.WriteLine(saque);
            foreach (var qntNota in qntNotas)
            {
                System.Console.Write("{0}, ",qntNota);
            }
            System.Console.WriteLine();
            for (int i=0; i < notas.Length; i++ ){ 
                System.Console.WriteLine("{0} notas de {1}",qntNotas[i],notas[i]);
            }
        }
    }
}

            // foreach (var nota in notas)
            // {
            //     while(saque >= nota){
            //         saque = saque - nota;
            //         if(nota==100){
            //         qntNotas[0]++;
            //         }
            //         else if(nota==50){
            //         qntNotas[1]++;
            //         }
            //         else if(nota==20){
            //         qntNotas[2]++;
            //         }
            //         else if(nota==10){
            //         qntNotas[3]++;
            //         }
            //         else if(nota==5){
            //         qntNotas[4]++;
            //         }
            //         else if(nota==2){
            //         qntNotas[5]++;
            //         }
            //         else if(nota==1){
            //         qntNotas[6]++;
            //         }
            //     }
            // }