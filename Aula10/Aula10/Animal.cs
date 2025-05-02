using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10
{
    public abstract class Animal
    {
        public string nome;
        public Animal(string nome)
        {
            this.nome = nome;
        }

        public abstract void EmitirSom();
    }
}
