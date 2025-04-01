using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Livro
    {
        public string titulo;
        public string autor;
        public int ano;

        public Livro(string titulo, string autor, int ano)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.ano = ano;
        }
    }
}
