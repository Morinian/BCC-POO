using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6
{
    class Gato : Animal
    {
        private int qtdVidas;

        public int QtdVidas
        {
            get { return qtdVidas; }
            set { qtdVidas = value; }
        }

        public Gato(int qtdVidas, string nome, string raca, double peso, string cor) : base (nome, raca, peso, cor)
        {
            this.qtdVidas = qtdVidas;
        }

        public void miar()
        {
            Console.WriteLine("O {0} MIOU!!", nome);
        }

    }
}
