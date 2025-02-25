using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3
{
    class Carro
    {
        public string Cor;
        public double velocidade;

        public void Acelera(ref double velocidade)
        {
            velocidade += 20.5;
            Console.WriteLine("{0} KM",velocidade);
        }

        public void Freia(ref double velocidade)
        {
            velocidade -= 20.5;
            Console.WriteLine("{0} KM", velocidade);
        }
    }
}
