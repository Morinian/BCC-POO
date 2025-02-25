using System;
using Aula3;
//Exercicio 1: Faça 3 instâncias de carros e atribua uma cor diferente para cada, Imprima cada um no terminal.
class Program
{
    static void Main(string[] args)
    {
        Exer3();
    }


    //Exercicio 3
    static void Exer3()
    {
        Carro civic = new Carro();
        civic.velocidade = 0;

        civic.Acelera(ref civic.velocidade);
        civic.Freia(ref civic.velocidade);
    }

    //Exercicio 1
    static void Exer1()
    {
        Carro civic = new Carro();
        Carro barbie = new Carro(); 
        Carro sonic = new Carro();

        civic.Cor = "Preto";
        barbie.Cor = "Rosa";
        sonic.Cor = "Azul";

        Console.WriteLine("Carro 1: {0}, Carro 2: {1}, Carro 3: {2}", civic.Cor, barbie.Cor, sonic.Cor);
    }

    //Exercicio 2
    static void Exer2()
    {
        int corNum; //A cor aleatória
        int[] qtdCor = new int[3]; //Vetor que contara a quantidade de cada cor

        List<Carro> listDeCarro = new List<Carro>(); //lista de carros 
        Random rand = new Random(); //Iniciando o random

        for (int i = 0; i < 1000; i++)
        {
            Carro carro = new Carro();//Criando a instancia
            corNum = rand.Next(1,4);//Randomizando a cor

            switch (corNum)
            {
                case 1:
                    carro.Cor = "Vermelho";
                    qtdCor[0]++;
                break;

                case 2:
                    carro.Cor = "Verde";
                    qtdCor[1]++;
                break;

                case 3:
                    carro.Cor = "Azul";
                    qtdCor[2]++;
                break;
            }

            listDeCarro.Add(carro);
        }

        Console.WriteLine("Qtd Vermelho: {0} \nQtd Verde: {1} \nQtd Azul: {2}", qtdCor[0] ,qtdCor[1], qtdCor[2]);


    }
}