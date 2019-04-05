using System;

namespace primeiro_aplicativo
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1;
            float nota2;
            float nota3;
            int faltas;
            double soma;
            double media;


            Console.WriteLine("Calculando a média...");
            Console.WriteLine("Digite a primeira nota:");
            nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota:");
            nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota:");
            nota3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de faltas");
            faltas = int.Parse(Console.ReadLine());

            soma = (nota1 + nota2 + nota3);
            media = (soma / 3);

            Console.WriteLine("");
            Console.WriteLine("Seu total de faltas foi: "+faltas);
            Console.WriteLine("Sua soma das suas notas foi: "+soma);
            Console.WriteLine("Sua média final foi: "+media);
            Console.WriteLine("");        

            if (media < 5 || faltas > 25)
            {
                Console.WriteLine("Reprovado");
            } else if (media < 9){
                Console.WriteLine("Aprovado!");
            }else{
                Console.WriteLine("Parabens pelo desempenho, Aprovado");
            }
        }
    }
}
