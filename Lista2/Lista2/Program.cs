using System;
using System.Runtime.Intrinsics.X86;
using Lista2;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Lista2
{
    class Program
    {
        static void Main(string[] args)
        {
            Exer2();
        }

        static void Exer1()
        {
            Funcionario funcionario = new Funcionario();

            Console.WriteLine("Escreva nome do funcionario");
            funcionario.nome = Console.ReadLine();
            Console.WriteLine("Escreva o CPF");
            funcionario.cpf = Console.ReadLine();
            Console.WriteLine("Escreva o salario bruto");
            funcionario.salarioBruto = Convert.ToDouble(Console.ReadLine());

            funcionario.Relatorio(funcionario);
        }
        //Implemente um software que simula um sistema de uma Biblioteca
        //• Crie uma classe Livro que contém informações de título, autor e ano de
        //publicação
        //• Crie uma classe Biblioteca que contém 0, 1 ou mais livros
        //• Na classe Biblioteca, deve ser possível alugar 1 livro, devolver 1 livro ou
        //imprimir a lista de livros, incluindo o título, autor e ano de publicação
        static void Exer2()
        {

        }
    }
}