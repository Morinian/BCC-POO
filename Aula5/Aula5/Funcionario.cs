using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5
{
    class Funcionario
    {
        private string nome;
        private string sobrenome;
        private double salario;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Sobrenome
        {
            get { return sobrenome; }
            set { sobrenome = value; }
        }
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public Funcionario(string nome, string sobrenome, double salario)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Salario = salario;
        }

        public void imprimirFuncionario()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Nome: {0}", nome);
            Console.WriteLine("Sobrenome: {0}", sobrenome);
            Console.WriteLine("Salario anual: {0}", salario*12);
        }
    }
}
