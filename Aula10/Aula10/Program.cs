using System;

namespace Aula10
{
    class Program
    {
        static void Main()
        {
            exer1();
        }

        static void exer1()
        {
            List<Animal> animais = new List<Animal>();

            Cachorro pingo = new Cachorro("pingo");
            Cachorro cristal = new Cachorro("cristal");
            Cachorro katano = new Cachorro("Katano");

            animais.Add(pingo);
            animais.Add(cristal);
            animais.Add(katano);

            for(int i =0; i < animais.Count; i++)
            {
                animais[i].EmitirSom();
            }

        }
    }
}