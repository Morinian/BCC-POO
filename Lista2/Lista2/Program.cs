using System;
using Lista2;


namespace Lista2
{
    class Program
    {
        static void Main(string[] args)
        {
            Exer1();
        }

        //Uma empresa precisa calcular os salários de seus funcionários.Sabe-se que um
        //funcionário possui um nome, cpf e salário.Um funcionário também tem seu salário líquido,    
        //que se baseia no seu salário, descontando impostos, a partir do valor do salário do
        //funcionário:
        //- Até R$ 2000: sem descontos
        //- De R$ 2000,01 a R$ 3000: 7,5%
        //- De R$ 3000,01 a R$ 4000: 15%
        //- De R$ 4000,01 a R$ 5000: 22,5%
        //- Acima de R$ 5000,01: 27,5%
        //A empresa quer poder calcular o total do pagamento no mês.No relatório, deve estar
        //contido o pagamento para cada funcionário, incluindo o salário bruto, a quantidade
        //descontada, e o salário líquido.No final, deve ser apresentado o total do salário bruto dos
        //funcionários, o total descontado, e o total do salário líquido.

        static void Exer1()
        {
            Funcionario funcionario = new Funcionario();

            Console.WriteLine("Escreva nome do funcionario");
            funcionario.nome = Console.ReadLine();
            Console.WriteLine("Escreva o CPF");
            funcionario.cpf = Console.ReadLine();
            Console.WriteLine("Escreva o salario bruto");
            funcionario.salarioBruto = Convert.ToDouble(Console.ReadLine());

            funcionario.Relatorio(funcionario);
        }
    }
}