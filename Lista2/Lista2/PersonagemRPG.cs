using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    class PersonagemRPG
    {
        private double vida;
        private double ataque;
        private double defesa;

        public double Vida
        {
            get { return vida; }
            set { vida = value; }
        }
        public double Ataque
        {
            get { return ataque; }
            set { ataque = value; }
        }

        public double Defesa
        {
            get { return defesa; }
            set { defesa = value; }
        }

        public PersonagemRPG (double vida, double ataque, double defesa)
        {
            Vida = vida;
            Ataque = ataque;
            Defesa = defesa;
        }

        public void atacar(PersonagemRPG atacado)
        {
            if (atacado.vida <= 0)
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
