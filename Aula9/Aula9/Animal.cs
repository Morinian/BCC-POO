using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula9
{
    class Animal
    {
        public string nome;
        public Animal(string nome)
        {
            this.nome = nome;
        }

        public virtual void EmitirSom()
        {
            Console.WriteLine("Emitiu um som");
        }
    }
}
