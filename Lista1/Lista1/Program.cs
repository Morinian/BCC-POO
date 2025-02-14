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

Exer1(args);