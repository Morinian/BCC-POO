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
            Exer3();
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
        static void Exer2()
        {
            Biblioteca nacional = new Biblioteca();

            Livro harry = new Livro();
            Livro escocia = new Livro();
            Livro logica = new Livro();
            Livro leroy = new Livro();

            harry.autor = "Mulher autora";
            escocia.autor = "Escocia autor";
            logica.autor = "Claro";
            leroy.autor = "Leroy Autor";

            harry.ano = "2026";
            escocia.ano = "2029";
            logica.ano = "1988";
            leroy.ano = "1890";

            harry.titulo = "Harry e a pedra";
            escocia.titulo = "Escocia um mundo novo";
            logica.titulo = "Logica basica";
            leroy.titulo = "Leroy a menina que iria longe";

            nacional.Adicionar(harry);
            nacional.Adicionar(escocia);
            nacional.Adicionar(logica);
            nacional.Adicionar(leroy);

            nacional.listarLivros();

            Console.WriteLine("\n");
            nacional.Alugar(harry);
            nacional.Alugar(leroy);
            Console.WriteLine("\n");

            nacional.listarLivros();
        }

        static void Exer3()
        {
            Personagem Brino = new Personagem();
            Personagem Felca = new Personagem();

            Brino.vida = 100;
            Brino.ataque = 40;
            Brino.defesa = 20;

            Felca.vida = 80;
            Felca.ataque = 10;
            Felca.defesa = 10;

            Brino.atacar(Felca);
            Brino.atacar(Felca);
            Brino.atacar(Felca);
            Brino.atacar(Felca);
        }
    }
}