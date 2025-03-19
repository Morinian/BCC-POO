using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    class Biblioteca
    {
        string nome;
        List<Livro> livros;

        public Biblioteca()
        {
            livros = new List<Livro>();
        }

        public void Adicionar(Livro livro)
        {
            livros.Add(livro);
        }

        public void Alugar(Livro livro)
        {
            livros.Remove(livro);
        }

        public void listarLivros()
        {
            for(int i = 0; i < livros.Count; i++)
            {
                Console.WriteLine("Livro: {0}", livros[i].titulo);
                Console.WriteLine("Autor: {0}", livros[i].autor);
                Console.WriteLine("Anor: {0}", livros[i].ano);
                Console.WriteLine("-----------  ");

            }
        }
    }
}
