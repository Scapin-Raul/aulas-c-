using System;

namespace exNotasKK
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalAlunos = 2;
            string[] nomes = new string[totalAlunos];
            string[] sobrenomes = new string[totalAlunos];
            int[] notas1 = new int[totalAlunos];
            int[] notas2 = new int[totalAlunos];
            string testeNota1;
            string testeNota2;
            
            for (int i = 0; i < nomes.Length; i++){
                Console.Write($"\nInsira o nome do {i+1}º aluno: ");
                nomes[i] = Console.ReadLine();
                Console.Write("Insira o sobrenome: ");
                sobrenomes[i] = Console.ReadLine();
    
                do{
                Console.Write("Insira a nota 1º nota (0 à 100): ");
                testeNota1 = Console.ReadLine();
                } while (!int.TryParse (testeNota1, out notas1[i]) || notas1[i]>100 || notas1[i]<0);
                
                do{
                Console.Write("Insira a nota 2º nota (0 à 100): ");
                testeNota2 = Console.ReadLine();    
                } while (!int.TryParse (testeNota2, out notas2[i]) || notas2[i]>100 || notas2[i]<0);
            }

            for (int i = 0; i < nomes.Length; i++){
                Console.WriteLine($"\n----Aluno {i+1}----");                
                Console.WriteLine($"| Nome: {nomes[i]} {sobrenomes[i]}");
                Console.WriteLine($"| A média final foi: {(notas1[i]+notas2[i])/2}");
                if( (notas1[i]+notas2[i])/2>=50 ){
                    Console.WriteLine($"| Aprovado!");
                }else{
                    Console.WriteLine($"| Reprovado!");
                }
                System.Threading.Thread.Sleep(1500);
            }   
        }
    }
}