using System;

namespace Biblioteca
{
    class Program
    {
        static void Main()
        {
            Pessoa Paula = new Pessoa("Paula", "489.590.192-09");
            Pessoa Gabriel = new Pessoa("Gabriel", "489.590.192-09");
            Biblioteca Nacional = new Biblioteca();

            Livro menina = new Livro("Menina que roubava livros", "Janette", 1980);

            Nacional.AdicionarLivro(menina);
            Nacional.AdicionarLivro(menina);
            Nacional.AlugarLivro(menina, Paula);
            Nacional.AlugarLivro(menina, Paula);
            Nacional.AlugarLivro(menina, Gabriel);
        }

    }
}