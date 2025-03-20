using System;

namespace Aula5
{
    class Program
    {
        static void Main()
        {
            Exer1();
        }

        static void Exer1()
        {
            Funcionario Paula = new Funcionario("Paula", "Martins", 1500);
            Funcionario Gabriel = new Funcionario("Gabriel", "Ferreira", 8000);
            Funcionario Fabio = new Funcionario("Fabio","Vidal",15000);

            Paula.imprimirFuncionario();
            Gabriel.imprimirFuncionario();
            Fabio.imprimirFuncionario();
        }
    }
}
