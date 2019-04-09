using System;

namespace exPassagemAviao
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            int resposta;
            int passagensRegistradas =0;
            string[] nomes = new string[2];
            int[] numPassagens = new int[2];
            DateTime[] data = new DateTime[2];

            while (continuar)
            {
                do{
                System.Console.WriteLine("\n---Escolha um dos menus---\n1- Registrar Passagem \n2- Visualizar Passagens \n0- Sair");
                resposta = int.Parse(Console.ReadLine());   
                }while (resposta != 1 && resposta != 2 && resposta != 0);

                if(resposta == 1){
                    if(passagensRegistradas < nomes.Length){   
                        System.Console.WriteLine("\n---Registro de Passagem---");
                        System.Console.Write($"Digite o nome do {passagensRegistradas + 1}º passageiro: ");
                        nomes[passagensRegistradas] = Console.ReadLine();
                        System.Console.Write($"Digite o nº da passagem: ");
                        numPassagens[passagensRegistradas] = int.Parse(Console.ReadLine());
                        System.Console.Write($"Digite a data do voo (dd/mm/aaaa): ");
                        data[passagensRegistradas] = DateTime.Parse(Console.ReadLine());
                        passagensRegistradas++;
                    }else{
                        System.Console.WriteLine("\nMáximo de registros atingido.");
                    }
                } //end if
                else if(resposta == 2){
                    for (int i = 0; i < nomes.Length; i++){   
                        if(nomes[i] != null){
                            System.Console.WriteLine($"\n---Passagem {i+1}---");
                            System.Console.WriteLine($"| Nome: {nomes[i]}. \n| Número da passagem: {numPassagens[i]}.\n| Data do voo: {data[i]:dd/MM/yyyy}.");
                        }
                    }
                            Console.ReadLine();
                
                }
                else{
                    System.Console.WriteLine("Agradecemos a preferência...");
                    continuar = false;
                }
            }
        }
    }
}
