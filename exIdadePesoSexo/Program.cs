using System;

namespace exIdadePesoSexo
{
    class Program
    {
        static void Main(string[] args)
        {
            int sexoTotalM =0;
            int sexoTotalF =0;
            float pesoSomaM =0;
            float pesoSomaF =0;
            int idadeSomaM =0;
            int idadeSomaF =0;
            string sexo= "";

            for(int pessoa = 1; pessoa <=4; pessoa++){
                do{
                System.Console.WriteLine("Escreva o sexo da {0}ª pessoa: (M ou F)",pessoa);
                sexo = Console.ReadLine().ToUpper();
                if(sexo != ("M") && sexo != ("F")){
                    System.Console.WriteLine("Valor inválido!");
                }
                }while (!sexo.Equals("M") && !sexo.Equals("F"));
                System.Console.Write("Escreva a idade da {0}ª pessoa: ",pessoa);
                int idade = int.Parse(Console.ReadLine());
                System.Console.Write("Escreva o peso da {0}ª pessoa: ",pessoa);
                float peso = float.Parse(Console.ReadLine());
                System.Console.WriteLine();

                if (sexo.Equals("F")){
                    sexoTotalF++;
                    pesoSomaF += peso;
                    idadeSomaF += idade;
                }
                else if (sexo.Equals("M")){
                    sexoTotalM++;
                    pesoSomaM += peso;
                    idadeSomaM += idade;
                }//fim if
            } //fim for
            if(sexoTotalF != 0){
                float pesoMedioF = (pesoSomaF/sexoTotalF);
                float idadeMediaF = (idadeSomaF/sexoTotalF);
                System.Console.WriteLine("O total de MULHERES é: {0}.  |  A média do peso das mulheres é: {1}.  |  A média do peso das mulheres é: {2}.",sexoTotalF,pesoMedioF,idadeMediaF);
            }else{
                System.Console.WriteLine("Não houve nenhuma mulher.");
            }//end if moças
            if(sexoTotalM != 0){
                float pesoMedioM = (pesoSomaM/sexoTotalM);
                float idadeMediaM = (idadeSomaM/sexoTotalM);
                System.Console.WriteLine("O total de HOMENS é: {0}.    |   A média do peso dos homens é: {1}.   |  A média do peso dos homens é: {2}.",sexoTotalM,pesoMedioM,idadeMediaM);
            } else{
                System.Console.WriteLine("Não houve nenhum homem.");
            }//end if homi
        }
    }
}