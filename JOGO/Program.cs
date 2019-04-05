using System;

namespace JOGO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("\nBem vindo ao Par ou Impar!");
            Console.WriteLine("---   ---   ---   ---");
            Console.WriteLine("Você quer jogar par ou ímpar?!");
            string respostaJogo = Console.ReadLine().ToLower();
            Console.WriteLine("---   ---   ---   ---");
            if(respostaJogo.Equals("sim")){
                Console.WriteLine("Certo!\nEscolha agora PAR ou IMPAR!");
                string respostaParOuImpar = Console.ReadLine().ToUpper();
                Console.WriteLine("---   ---   ---   ---");
                 
                if (respostaParOuImpar.Equals("PAR")||respostaParOuImpar.Equals("IMPAR") ){

                    Console.WriteLine("Ok, você escolheu "+respostaParOuImpar+".");
                    Console.WriteLine("Agora, escolha um número de 0 à 10!");
                    int numeroJogador = int.Parse(Console.ReadLine());
                    Console.WriteLine("---   ---   ---   ---");

                    if (numeroJogador >= 0 && numeroJogador <= 10){
                        Console.WriteLine("PC: Agora escolherei meu número!");
                        System.Threading.Thread.Sleep(800);
                        Random r = new Random();
                        int numeroPC = r.Next(0,10);
                        Console.WriteLine(numeroPC);
                        Console.WriteLine("---   ---   ---   ---");
                        System.Threading.Thread.Sleep(1000);

                        int resultadoSoma = numeroJogador + numeroPC;
                        int resultadoFinal = resultadoSoma % 2;
                        if (resultadoFinal == 0 && respostaParOuImpar.Equals("PAR")){
                            // PAR GANHADOR
                            Console.WriteLine("Parabéns voçê me derrotou! Ganhou 4 trilhões de euros e 30 pontos de QI!");
                            System.Threading.Thread.Sleep(1000);
                            Console.Write("Encerrando jogo");
                            System.Threading.Thread.Sleep(700);
                            Console.Write(".");
                            System.Threading.Thread.Sleep(700);
                            Console.Write(".");
                            System.Threading.Thread.Sleep(700);
                            Console.Write(".");
                            System.Threading.Thread.Sleep(700);
                        }
                        else if(resultadoFinal != 0 && respostaParOuImpar.Equals("PAR")){
                            // PAR PERDEDOR
                            Console.WriteLine("Você perdeu!");
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine("Que pena, sua alma agora é minha!");
                            System.Threading.Thread.Sleep(1000);
                            Console.Write("Encerrando jogo");
                            System.Threading.Thread.Sleep(700);
                            Console.Write(".");
                            System.Threading.Thread.Sleep(700);
                            Console.Write(".");
                            System.Threading.Thread.Sleep(700);
                            Console.Write(".");
                            System.Threading.Thread.Sleep(700);
                        }


                        else if(resultadoFinal == 0 && respostaParOuImpar.Equals("IMPAR")){
                            // IMPAR PERDEDOR
                            Console.WriteLine("Você perdeu!");
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine("Que pena, sua alma agora é minha!");
                            System.Threading.Thread.Sleep(1000);
                            Console.Write("Encerrando jogo");
                            System.Threading.Thread.Sleep(700);
                            Console.Write(".");
                            System.Threading.Thread.Sleep(700);
                            Console.Write(".");
                            System.Threading.Thread.Sleep(700);
                            Console.Write(".");
                            System.Threading.Thread.Sleep(700);
                        }

                        else if(resultadoFinal != 0 && respostaParOuImpar.Equals("IMPAR")){
                            // IMPAR GANHADOR
                            Console.WriteLine("Parabéns voçê me derrotou! Ganhou 4 trilhões de euros e 30 pontos de QI!");
                            System.Threading.Thread.Sleep(1000);
                            Console.Write("Encerrando jogo");
                            System.Threading.Thread.Sleep(700);
                            Console.Write(".");
                            System.Threading.Thread.Sleep(700);
                            Console.Write(".");
                            System.Threading.Thread.Sleep(700);
                            Console.Write(".");
                            System.Threading.Thread.Sleep(700);     
                        }
                        
                        
                    
                        else{
                            Console.WriteLine("Você inseriu um valor inválido...");
                            System.Threading.Thread.Sleep(1000);
                            Console.Write("Encerrando jogo");
                            System.Threading.Thread.Sleep(700);
                            Console.Write(".");
                            System.Threading.Thread.Sleep(700);
                            Console.Write(".");
                            System.Threading.Thread.Sleep(700);
                            Console.Write(".");
                            System.Threading.Thread.Sleep(700);
                        }
                    }
                     else{
                        Console.WriteLine("Sua resposta foi inválida...");
                        System.Threading.Thread.Sleep(1000);
                        Console.Write("Encerrando jogo");
                        System.Threading.Thread.Sleep(700);
                        Console.Write(".");
                        System.Threading.Thread.Sleep(700);
                        Console.Write(".");
                        System.Threading.Thread.Sleep(700);
                        Console.Write(".");
                        System.Threading.Thread.Sleep(700);
                    }



                }   
                
                    


                




            }else{
                System.Threading.Thread.Sleep(300);
                Console.WriteLine("Sinto muito, queria tanto jogar com você...");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Até a próxima...");
                System.Threading.Thread.Sleep(1000);
                Console.Write("Encerrando jogo");
                System.Threading.Thread.Sleep(700);
                Console.Write(".");
                System.Threading.Thread.Sleep(700);
                Console.Write(".");
                System.Threading.Thread.Sleep(700);
                Console.Write(".");
                System.Threading.Thread.Sleep(700);
            }



        }
    }
}
