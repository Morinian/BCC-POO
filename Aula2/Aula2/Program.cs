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

//Exercicio 2
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

//Exercicio 3
//Faça um programa que recebe nomes de diferentes animais
//Cada vez que o usuário digitar o nome de um animal, o programa deve
//checar se o nome já foi digitado anteriormente. Se foi, então deve ser exibido
//uma mensagem alertando que o nome já foi digitado
static void Exer3(string[] args)
{
    List<string> animais = new List<string>();
    string nomeTemp;
    bool parar = false;

    while(parar == false)
    {
        Console.WriteLine("Escreva nome de um animal");
        nomeTemp = Console.ReadLine();

        for (int i = 0; i < animais.Count; i++)
        {
            if (nomeTemp == animais[i])
            {
                Console.WriteLine("JÁ FOI INSERIDO ESSE ANIMAL");
            }
        }
        animais.Add(nomeTemp);

        Console.WriteLine("Escreva true Se quiser parar ou false para continuar");
        parar = Convert.ToBoolean(Console.ReadLine());

    }

    Console.WriteLine("Sua lista:");
    for (int i = 0; i < animais.Count; i++)
    {
     Console.WriteLine("{0}", animais[i]);
    }
}

//Exercicio 4
//Faça um programa que simula uma lista de tarefas
//• O programa deve permitir que o usuário insira uma tarefa ou remova uma
//tarefa
//• O usuário deve poder escrever a tarefa
//• O programa também deve poder imprimir a lista de tarefas
static void Exer4(string[] args)
{
    List<string> tarefas = new List<string>();
    string tarefaTemp;
    int opcao = 0, numTarefa;

    Console.WriteLine("Bem vindo a sua lista de tarefas");
    while (opcao != 4){
        Console.WriteLine("1-Excluir Tarefa");
        Console.WriteLine("2-Adicionar Tarefa");
        Console.WriteLine("3-Listar tarefas");
        Console.WriteLine("4-Sair");

        opcao = Convert.ToInt32(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                Console.WriteLine("Qual tarefa você quer excluir?");
                numTarefa = Convert.ToInt32(Console.ReadLine());
                tarefas.RemoveAt(numTarefa - 1);
                break;
            case 2:
                Console.WriteLine("Qual tarefa você quer adicionar?");
                tarefaTemp = Console.ReadLine();
                tarefas.Add(tarefaTemp);
                break;
            case 3:
                Console.WriteLine("------------------");
                for (int i = 0; i < tarefas.Count; i++)
                {
                    Console.WriteLine("{0}) {1}", i + 1, tarefas[i]);
                }
                Console.WriteLine("------------------");
                break;
            case 4:
                break;
        }
    }
    
}

//Exercicio 5
//Faça um programa que simula um caixa de supermercado
//• O usuário deve poder adicionar um item e sua quantidade
//• Se o item já existir na lista, a nova quantidade deve ser acrescentada a
//quantidade atual
//• Permita imprimir a lista inteira juntamente com a quantidade de elementos
//da lista
static void Exer5(string[] args)
{
    Dictionary<string, int> listaMercado = new Dictionary<string, int>();
    int qtdTemp;
    string nomeTemp;
    bool parar = false;

    while (parar == false)
    {
        Console.WriteLine("Escreva nome do item");
        nomeTemp = Console.ReadLine();
        Console.WriteLine("Escreva a quantidade do item");
        qtdTemp = Convert.ToInt32(Console.ReadLine());

        if (listaMercado.ContainsKey(nomeTemp))
        {
            listaMercado[nomeTemp] += qtdTemp;
        }
        else
        {
            listaMercado.Add(nomeTemp, qtdTemp);
        }

        Console.WriteLine("Escreva true Se quiser parar ou false para continuar");
        parar = Convert.ToBoolean(Console.ReadLine());

    }

    Console.WriteLine("LISTA DE COMPRAS--------------");
    foreach (var item in listaMercado)
    {
        Console.WriteLine($"{item.Key}: {item.Value}");
    }
}

Exer5(args);