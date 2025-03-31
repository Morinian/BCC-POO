using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6
{
    class Animal
    {
        protected string nome;
        protected string raca;
        protected double peso;
        protected string cor;

        public string Nome{
            get { return nome; }
            set { nome = value; }
        }
        public Animal(string nome, string raca, double peso, string cor)
        {
            this.nome = nome;
            this.raca = raca;
            this.peso = peso;
            this.cor = cor;
        }

        public void pular()
        {
            Console.WriteLine("O {0} pulou!!", nome);
        }
    }
}
