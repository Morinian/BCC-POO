using System; //.NET

string nome = "Paula";
string sobrenome = "Martins";

Console.WriteLine("Ola, {0} {1}", nome, sobrenome);
//Utilização de indices 

Console.WriteLine($"Ola, {nome} {sobrenome}");
//Utilização de template

Console.WriteLine("Escreva seu nome:");
nome = Console.ReadLine();

Console.WriteLine($"Seu nome é {nome} ");

//EXERCICIOS 1
/*
Faça um programa que solicita o nome o sobrenome do usuario separadamente. 
,Depois disso, imprima o nome completo no terminal Faça isso usando tanto a 
concatenação por operadores quanto por formato e quanto por template
*/

string nomePessoa;
string sobrenomePessoa;

Console.WriteLine("Escreva seu nome:");
nomePessoa = Console.ReadLine();
Console.WriteLine("Escreva seu sobrenome:");
sobrenomePessoa = Console.ReadLine();

Console.WriteLine("Bem vindo {0} {1}", nomePessoa, sobrenomePessoa);
Console.WriteLine("Bem vindo " + nomePessoa + sobrenomePessoa);
Console.WriteLine($"Bem vindo {nomePessoa} {sobrenomePessoa}");

//CONTINUAÇÃO DA AULA

Console.WriteLine("Digite um numero");
string numEntrada = Console.ReadLine();
int num = Int32.Parse(numEntrada);
// classe que converte para int

//outra maneira meljhor é usar Covert.to(algo)double(num);

int soma = num + 201;
Console.WriteLine("Resultado da soma é {0} ", soma);
//ele converte automaticamente para string para escrever

//EXERCICIO 2

/*
 Faça um programa que solicita os seguintes dados de um usuario
-nome 
-sobrenome 
- idade
-peso
-altura
Imprima uma ficha com o nome completo da pessoa , a idade e o seu IMC
-O calculo do IMC é o peso / (altura^2)
 */

Console.WriteLine("****************************");
Console.WriteLine("Boas vindas");
Console.WriteLine("****************************");

Console.WriteLine("Escreva seu nome: ");
string nomeExer2 = Console.ReadLine();

Console.WriteLine("Escreva seu sobrenome: ");
string sobrenomeExer2 = Console.ReadLine();

Console.WriteLine("Escreva seu idade: ");
string entrada1 = Console.ReadLine();
int idade = Convert.ToInt32(entrada1);

Console.WriteLine("Escreva seu peso: ");
string entrada2 = Console.ReadLine();
double peso = Convert.ToDouble(entrada2);

Console.WriteLine("Escreva seu altura: ");
string entrada3 = Console.ReadLine();
double altura = Convert.ToDouble(entrada3);

double imc = peso / (altura * altura);

Console.WriteLine("*****************************");
Console.WriteLine("Seu nome: {0}", nomeExer2);
Console.WriteLine("Seu sobrenome: {0}", sobrenomeExer2);
Console.WriteLine("Sua idade: {0}", idade);
Console.WriteLine("Sua altura: {0}", altura);
Console.WriteLine("Seu peso: {0}", peso);
Console.WriteLine("Seu imc é: {0}", imc);
Console.WriteLine("*****************************");

//EXERCICIO 3
/*
   Faça um programa que recebe dois numeros
Ambos os numeros devem ser positivos e o segundo numero tem que 
ser maior ou igual ao primeiro se não for deve ser eibido um erro
Sortei um numero que esteja entre os dois numeros digitados
 */

Random sorteador = new Random();

int num1Sorteado = sorteador.Next(0, 100);
Console.WriteLine(num1Sorteado);

int num2Sorteado = sorteador.Next(0, 100);
Console.WriteLine(num2Sorteado);

if (num1Sorteado < num2Sorteado)
{
    int numSurpresa = sorteador.Next(num1Sorteado, num2Sorteado);
    Console.WriteLine(numSurpresa);
}
else
{
    Console.WriteLine("ERRO");
}