using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula9
{
    class Cachorro : Animal
    {
        public Cachorro (string nome) : base(nome)
        {

        }
        public override void EmitirSom()
        {
            base.EmitirSom();
            Console.WriteLine("AUAU");
        }
    }
}
