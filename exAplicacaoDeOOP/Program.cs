using System;

namespace exAplicacaoDeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo à AirLines!");
            bool sair = false;
            Passageiro[] passageiros = new Passageiro[5];
            int passageirosCadastrados = 0;

            do {
                System.Console.WriteLine ("\n---Escolha um dos menus---\n1- Registrar Passagem \n2- Visualizar Passagens \n3- Registrar Aeronave\n4- Visualizar Aeronaves \n0- Sair");
                int resposta = int.Parse (Console.ReadLine ());
                
                switch (resposta)
                {
                    case 1:
                        Passageiro p = new Passageiro();
                        System.Console.WriteLine("Insira o nome do passageirokkkk");
                        p.setNome(Console.ReadLine());

                        System.Console.WriteLine("Insira o numero do passageiro");
                        p.setNumPassagem(int.Parse(Console.ReadLine()));

                        System.Console.WriteLine("Insira a data do voo (dd/mm)");
                        p.setData(DateTime.Parse(Console.ReadLine()));
                        passageiros[passageirosCadastrados] = p;
                        
                        System.Console.WriteLine("Passageiro cadastradokkkk");
                        passageirosCadastrados++;
                    break;
                    
                    case 2:
                        for (int i=0; i <passageirosCadastrados; i++){
                            System.Console.WriteLine ($"\n---Passagem {i+1}---");
                            System.Console.WriteLine($"| Nome: {passageiros[i].getNome()}");
                            System.Console.WriteLine($"| Nº: {passageiros[i].getNumPassagem()}");
                            System.Console.WriteLine($"| Data do voo: {passageiros[i].getData():dd/MMMM}");
                        }
                        Console.Write ("\nAperte ENTER para retornar ao menu. ");
                        Console.ReadLine ();
                    break;
                    
                    case 3: //registrar aeronaves
                        System.Console.WriteLine("kk");
                    break;

                    case 4: //exibir aeronaves
                        System.Console.WriteLine("kkkk");
                    break;





                    case 0:
                        System.Console.WriteLine("Agradecemos a preferência...");
                        sair = true;
                    break;
                }
            } while (!sair);



        }
    }
}
