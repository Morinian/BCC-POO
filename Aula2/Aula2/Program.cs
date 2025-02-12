using System;
using System.Collections.Generic; //Biblioteca para utilização da lista

//Exercicio 1
//Faça um programa que receba 5 notas de 5 alunos. O programa deve calcular
//a média de cada aluno
static void Exer1(string[] args)
{
    double[,] notas = new double[5, 5];
    double[] media = new double[5];
    double soma; 

    Console.WriteLine("Escreva as notas dos alunos");

    for (int i = 0;i < 5; i++)
    {
        soma = 0;
        Console.WriteLine("aluno {0}", i+1);
        for (int j = 0; j < 5; j++)
        {
            Console.WriteLine("nota {0}: ",j+1);
            notas[i, j] = Convert.ToDouble(Console.ReadLine());

            soma += notas[i, j];
        }
        media[i] = soma / 5;
    }
    
    Console.WriteLine("Boletim");
    for (int i = 0; i <5; i++)
    {
        Console.WriteLine("Aluno {0} média: {1}", i+1 , media[i]);
    }
}

//Exercicio 1
//Faça um programa que receba 5 notas de apenas 1 aluno. O programa deve
//calcular a média desse aluno.
static void Exer2(string[] args)
{
    List<double> notas = new List<double>();
    double media = 0;

    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("nota {0}: ", i+1);
        double nota = Convert.ToDouble(Console.ReadLine());
        notas.Add(nota);

        media += notas[i];
    }
    media = media / 5;
    Console.WriteLine("Média: {0} ", media);
}

Exer2(args);