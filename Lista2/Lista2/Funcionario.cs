using System;

namespace Lista2
{
    public class Funcionario
    {
        public string nome;
        public string cpf;
        public double salarioBruto;
        public double salarioLiquido;


        public void Relatorio(Funcionario funcionario)
        {
            Console.WriteLine("---------RELATORIO---------");
            Console.WriteLine("Nome: {0}", funcionario.nome);
            Console.WriteLine("CPF: {0}", funcionario.cpf);

            if(funcionario.salarioBruto < 2000)
            {
                funcionario.salarioLiquido = funcionario.salarioBruto;
                Console.WriteLine("Nada foi descontado\nSalario Bruto: {0} \nSalario Liquido: {1}",funcionario.salarioBruto, funcionario.salarioLiquido);
            }else if( funcionario.salarioBruto >= 2000.01 && funcionario.salarioBruto <= 3000)
            {
                funcionario.salarioLiquido = funcionario.salarioBruto - (funcionario.salarioBruto * 0.075);
                Console.WriteLine("7,5% foi descontado\nSalario Bruto: {0} \nSalario Liquido: {1}", funcionario.salarioBruto, funcionario.salarioLiquido);
            }
            else if (funcionario.salarioBruto >= 3000.01 && funcionario.salarioBruto <= 4000)
            {
                funcionario.salarioLiquido = funcionario.salarioBruto - (funcionario.salarioBruto * 0.15);
                Console.WriteLine("15% foi descontado\nSalario Bruto: {0} \nSalario Liquido: {1}", funcionario.salarioBruto, funcionario.salarioLiquido);
            }
            else if (funcionario.salarioBruto >= 4000.01 && funcionario.salarioBruto <= 5000)
            {
                funcionario.salarioLiquido = funcionario.salarioBruto - (funcionario.salarioBruto * 0.225);
                Console.WriteLine("22,5% foi descontado\nSalario Bruto: {0} \nSalario Liquido: {1}", funcionario.salarioBruto, funcionario.salarioLiquido);
            }
            else if (funcionario.salarioBruto > 5000.01)
            {
                funcionario.salarioLiquido = funcionario.salarioBruto - (funcionario.salarioBruto * 0.275);
                Console.WriteLine("27,5% foi descontado\nSalario Bruto: {0} \nSalario Liquido: {1}", funcionario.salarioBruto, funcionario.salarioLiquido);
            }
        }
    }
}

