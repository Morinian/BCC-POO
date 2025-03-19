using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    class Personagem
    {
        public double vida;
        public double ataque;
        public double defesa;

        public void atacar(Personagem atacado)
        {
            if(atacado.vida <= 0)
            {
                Console.WriteLine("\nEle esta sem vida");
            }
            else
            {
                atacado.vida = atacado.vida - (ataque - atacado.defesa);

                if (atacado.vida < 0)
                    atacado.vida = 0;

                Console.WriteLine("\nEle ficou com {0} de vida", atacado.vida);
            }
        }
    }
}
