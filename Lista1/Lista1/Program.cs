using System;

//Exercício 1 - Calculadora

//● Ao entrar na calculadora o usuário deverá ter um menu com as opções 1, 2, 3, 4 e 0.
//Sendo elas:
//1 - Somar
//2 - Subtrair
//3 - Multiplicar
//4 - Dividir
//0 - Sair

//● Todas as operações devem solicitar que o usuário entre com dois valores e então
//estes valores devem ser utilizados para realizar a operação escolhida. Exemplo de
//fluxo da operação de Soma:
//i.Aplicação solicita o primeiro valor;
//ii.Usuário digita valor e pressiona enter;
//iii.Aplicação solicita o segundo valor;
//iv.Usuário digita valor e pressiona enter;
//v.Aplicação escreve em tela o resultado da soma;
//vi.Usuário pressiona Enter;
//vii.Aplicação retorna para o menu;
//● Para a operação de divisão, validar se o divisor é 0. Se verdadeiro deve ser exibida
//a mensagem "Não é possível dividir por zero."

//Desafios
//1. Crie uma nova opção na calculadora (opção número 5 do menu) que retorne o resto
//da divisão.
//2. Crie uma nova opção na calculadora (opção número 6 do menu) que retorne o
//resultado da potenciação de uma determinada base pelo seu expoente. Exemplo 2³ = 8.

static void Exer1(string[] args)
{
    int menu = 1;
    double num1, num2, resultado = 1;

    while (menu != 0)
    {
        Console.WriteLine("\nCALCULADORA:");
        Console.WriteLine("1 - Somar");
        Console.WriteLine("2 - Subtrair");
        Console.WriteLine("3 - Multiplicar");
        Console.WriteLine("4 - Dividir");
        Console.WriteLine("5 - Resto da divisão");
        Console.WriteLine("6 - Potenciação");
        Console.WriteLine("0 - Sair\n");

        menu = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Numero 1:");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Numero 2:");
        num2 = Convert.ToInt32(Console.ReadLine());

        switch (menu)
        {
            case 1:
                resultado = num1 + num2;
                Console.WriteLine("O resultado da soma: {0}", resultado);
                break;

            case 2:
                resultado = num1 - num2;
                Console.WriteLine("O resultado da subtração: {0}", resultado);
                break;

            case 3:
                resultado = num1 * num2;
                Console.WriteLine("O resultado da multiplicação: {0}", resultado);
                break;

            case 4:
                if (num1 == 0 || num2 == 0)
                {
                    Console.WriteLine("Não é possível dividir por zero.");
                }
                else
                {
                    resultado = num1 / num2;
                    Console.WriteLine("O resultado da divisão: {0}", resultado);
                }
                break;

            case 5:
                resultado = num1 % num2;
                Console.WriteLine("O resto da divisão é: {0}", resultado);
                break;

            case 6:
                for(int i = 0; i < num2; i++)
                {
                    resultado *= num1;
                }
                Console.WriteLine("O resto da potencialização é: {0}", resultado);
                break;

            case 0:
                break;
        }
    }
}

// Exercício 2 - Soma e Média
//Objetivo: usando uma aplicação do tipo console do dotnet, criar uma aplicação que lê 3 à
//10 números e realiza a soma e a média deles. 

//Novos conceitos ou funcionalidades desse exercício
//Faremos uso de loops e arrays no exercício, tente fazer o mesmo usando ´for´ e o ´foreach´.
//Faça o possível também para criar métodos que recebam parâmetros e retornem valores,
//dessa forma teremos uma codificação mais limpa e de fácil leitura.

//Estudar:
//● Criação de métodos
//● Receber parâmetros nos métodos
//● Retorno de valores nos métodos
//● Classe ´List´ do Dotnet
//● Loops ´for´ e ´foreach´

//Requisitos para desenvolver a aplicação
//● Ao abrir a aplicação deverá ser solicitado a quantidade de números que o usuário
//deseja informar. O número de valores deve ser entre 3 e 10.
//● A aplicação deve aceitar números decimais, positivos e negativos.
//● A aplicação deve percorrer a lista de números, calcular a soma e a média dos
//valores informados e imprimir o resultado para o usuário.

//Desafios
//1. Validar se os números digitados pelo usuário são validos (estude o TryParse para
//fazer esse desafio).
//2. Faça o uso da biblioteca "System.Linq" do Dotnet para fazer a soma (sum) e a
//média (average) da lista (array) de valores

static void Exer2(string[] args)
{

}

Exer2(args);