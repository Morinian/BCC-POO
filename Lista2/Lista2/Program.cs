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
            Exer6();
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

        //    A faculdade Canses ainda utiliza papel e caneta para realizar o cálculo do aluno matriculado
        //em uma disciplina, e lhe contratou para criar um programa que automatize isso.Porém,
        //cada disciplina possui uma nota diferente para aprovação. Enquanto em Algoritmos o aluno
        //só precisa da nota 5 para ser aprovado, em Cálculo, o aluno precisa da nota 7.
        //Crie um programa onde seja possível cadastrar alunos em uma disciplina.Deve ser
        //possível realizar a média da disciplina, e checar se um aluno está aprovado ou não em uma
        //determinada disciplina.Garanta que seja possível imprimir uma relação dos nomes dos
        //alunos, suas notas na disciplina e se ele está aprovado ou não.

        static void Exer6()
        {
            Aluno Paula = new Aluno("Paula");
            Disciplina Calculo = new Disciplina("Matematica",7.0);
            Calculo.adicionarNota(Paula, new List<double> { 2.5, 6, 7,6 });
            Calculo.verAprovação(Paula);
        }

        static void Exer5()
        {
            PersonagemRPG Brino = new PersonagemRPG(100,40,20);
            PersonagemRPG Felca = new PersonagemRPG(80,10,10);

            Brino.atacar(Felca);
            Brino.atacar(Felca);
            Brino.atacar(Felca);
            Brino.atacar(Felca);
        }
    }
}