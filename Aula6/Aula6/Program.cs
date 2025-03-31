using System;

namespace Aula6
{
    class Program { 
    
        static void Main()
        {
            Exer1();
        }

        static void Exer1()
        {
            Gato caramelo = new Gato(3,"gab","caramel",89.9,"branco");
            Console.WriteLine("Gato {0}", caramelo.Nome);

        }
    }
}