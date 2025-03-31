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
            Exer7();
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

        static void Exer5()
        {
            PersonagemRPG Brino = new PersonagemRPG(100,40,20);
            PersonagemRPG Felca = new PersonagemRPG(80,10,10);

            Brino.atacar(Felca);
            Brino.atacar(Felca);
            Brino.atacar(Felca);
            Brino.atacar(Felca);
        }

        static void Exer6()
        {
            Aluno Paula = new Aluno("Paula");
            Disciplina Calculo = new Disciplina("Matematica", 7.0);
            Calculo.adicionarNota(Paula, new List<double> { 2.5, 6, 7, 6 });
            Calculo.verAprovação(Paula);
        }

        //Faça um programa de uma agenda telefônica.Uma agenda telefônica deve possuir
        //contatos, onde cada contato possui nome, email e telefone.Após cadastrado, deve ser
        //possível alterar os dados cadastrais de um contato.
        //Deve ser possível realizar um cadastro de um novo contato em uma agenda telefônica,
        //remover um contato, ou buscar um contato por nome ou por email, devolvendo seu telefone.

        static void Exer7() {
            ListaTelefonica casa = new ListaTelefonica();

            Contato Gabriel = new Contato("Gabriel", "gab@gmail.com", "(11)9837-281");
            Contato Paula = new Contato("Paula", "paula@gmail.com", "(11)9456-781");

            casa.AdicionarContato(Paula);
            casa.AdicionarContato(Gabriel);

            casa.Listar();

            casa.ExcluirContato(Paula);

            casa.Listar();

            casa.BuscarContato(Gabriel);

            casa.EditarContato(Gabriel, "Gabriel", "otario@gmail.com", "(11)9837-281");

            casa.Listar();
        }
    }
}