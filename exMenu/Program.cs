using System;

namespace exMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha =0;
            bool repetir = true;
            string login = "Guerreiro(a)";
            while(repetir){
            Console.WriteLine("==============================\nBem vindo - {0}\n------------------------------\nEscolha uma das opçoes para acessar:\n 1- Efetuar login \n 2- Contato \n 3- Listar Comentarios \n 9- Sair",login);
            escolha = int.Parse(Console.ReadLine());
            

            
                switch(escolha){
                    case 1:
                        Console.Write("Login:");
                        login = Console.ReadLine();
                        Console.Write("Senha:");
                        string senha =Console.ReadLine();
                        Console.WriteLine("Bem vindo - {0}",login);
                        System.Console.WriteLine("\nDigite ENTER para voltar ao menu");
                        Console.ReadLine();
                       
                    escolha = 0;
                    break;

                    case 2:
                        Console.WriteLine("Você acessou a área de Contato");
                        System.Console.WriteLine("\nDigite ENTER para voltar ao menu");
                        Console.ReadLine();
                    escolha = 0;
                    break;

                    case 3:
                        Console.WriteLine("Você acessou a área de Listar Comentarios");
                        System.Console.WriteLine("\nDigite ENTER para voltar ao menu");
                        Console.ReadLine();
                    escolha = 0;
                    break;
                    
                    case 9:
                    repetir=false;
                    break;
                }
            }
        }
    }
}
