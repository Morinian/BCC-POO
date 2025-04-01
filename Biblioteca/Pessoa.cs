using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Pessoa
    {
        private string nome;
        private string cpf;
        public bool pegou_livro;

        public string Nome
        {
            get { return nome; }
            set { nome = value;}
        }
        public string Cpf
        {
            get { return nome; }
            set { nome = value; }
        }

        public Pessoa(string nome, string cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
            pegou_livro = false;
        }
    }
}
