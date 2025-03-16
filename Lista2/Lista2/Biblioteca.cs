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

        public void Adicionar(Livro livro)
        {
            livros.Add(livro);
        }
    }
}
