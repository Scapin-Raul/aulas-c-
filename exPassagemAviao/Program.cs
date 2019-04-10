using System;

namespace exPassagemAviao {
    class Program {
        static void Main (string[] args) {
            bool continuar = true;
            int resposta;
            int passagensRegistradas = 0;
            string[] nomes = new string[4];
            int[] numPassagens = new int[4];
            DateTime[] data = new DateTime[4];
            string testePassagem;
            string testeData;

            while (continuar) {
                do {
                    System.Console.WriteLine ("\n---Escolha um dos menus---\n1- Registrar Passagem \n2- Visualizar Passagens \n0- Sair");
                    resposta = int.Parse (Console.ReadLine ());
                } while (resposta != 1 && resposta != 2 && resposta != 0);

                if (resposta == 1) {
                    if (passagensRegistradas < nomes.Length) {
                        System.Console.WriteLine ("\n---Registro de Passagem---");
                        System.Console.Write ($"Digite o nome do {passagensRegistradas + 1}º passageiro: ");
                        nomes[passagensRegistradas] = Console.ReadLine ();
                        do {
                            System.Console.Write ($"Digite o nº da passagem: ");
                            testePassagem = Console.ReadLine ();
                        } while (!int.TryParse (testePassagem, out numPassagens[passagensRegistradas]));
                        do {
                            System.Console.Write ($"Digite a data do voo (dd/mm/aaaa): ");
                            testeData = Console.ReadLine ();
                        } while (!DateTime.TryParse (testeData, out data[passagensRegistradas]));
                        System.Console.WriteLine("Passagem cadastrada com sucesso.");
                        passagensRegistradas++;
                    } else {
                        System.Console.WriteLine ("\nMáximo de registros atingido.");
                    }
                } //end if
                else if (resposta == 2) {
                    for (int i = 0; i < nomes.Length; i++) {
                        if (nomes[i] != null) {
                            System.Console.WriteLine ($"\n---Passagem {i+1}---");
                            System.Console.WriteLine ($"| Nome: {nomes[i]}. \n| Número da passagem: {numPassagens[i]}.\n| Data do voo: {data[i]:dd/MM/yyyy}.");
                        }
                    }
                    Console.Write ("\nAperte ENTER para retornar ao menu. ");
                    Console.ReadLine ();
                } else {
                    System.Console.WriteLine ("Agradecemos a preferência...");
                    continuar = false;
                }
            } //end while
        }
    }
}