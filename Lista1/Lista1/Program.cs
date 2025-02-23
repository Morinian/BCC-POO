using System;
using System;
using System.Collections.Generic; //Biblioteca para utilização da lista
using System.IO; //Biblioteca para utilização de leitura de arquivo


//Exercício 1 - Calculadora

//● Ao entrar na calculadora o usuário deverá ter um menu com as opções 1, 2, 3, 4 e 0.
//Sendo elas:
//1 - Somar
//2 - Subtrair
//3 - Multiplicar
//4 - Dividir
//0 - Sair

//● Todas as operações devem solicitar que o usuário entre com dois valores e então
//estes valores devem ser utilizados para realizar a operação escolhida. Exemplo de
//fluxo da operação de Soma:
//i.Aplicação solicita o primeiro valor;
//ii.Usuário digita valor e pressiona enter;
//iii.Aplicação solicita o segundo valor;
//iv.Usuário digita valor e pressiona enter;
//v.Aplicação escreve em tela o resultado da soma;
//vi.Usuário pressiona Enter;
//vii.Aplicação retorna para o menu;
//● Para a operação de divisão, validar se o divisor é 0. Se verdadeiro deve ser exibida
//a mensagem "Não é possível dividir por zero."

//Desafios
//1. Crie uma nova opção na calculadora (opção número 5 do menu) que retorne o resto
//da divisão.
//2. Crie uma nova opção na calculadora (opção número 6 do menu) que retorne o
//resultado da potenciação de uma determinada base pelo seu expoente. Exemplo 2³ = 8.

static void Exer1(string[] args)
{
    int menu = 1;
    double num1, num2, resultado = 1;

    while (menu != 0)
    {
        Console.WriteLine("\nCALCULADORA:");
        Console.WriteLine("1 - Somar");
        Console.WriteLine("2 - Subtrair");
        Console.WriteLine("3 - Multiplicar");
        Console.WriteLine("4 - Dividir");
        Console.WriteLine("5 - Resto da divisão");
        Console.WriteLine("6 - Potenciação");
        Console.WriteLine("0 - Sair\n");

        menu = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Numero 1:");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Numero 2:");
        num2 = Convert.ToInt32(Console.ReadLine());

        switch (menu)
        {
            case 1:
                resultado = num1 + num2;
                Console.WriteLine("O resultado da soma: {0}", resultado);
                break;

            case 2:
                resultado = num1 - num2;
                Console.WriteLine("O resultado da subtração: {0}", resultado);
                break;

            case 3:
                resultado = num1 * num2;
                Console.WriteLine("O resultado da multiplicação: {0}", resultado);
                break;

            case 4:
                if (num1 == 0 || num2 == 0)
                {
                    Console.WriteLine("Não é possível dividir por zero.");
                }
                else
                {
                    resultado = num1 / num2;
                    Console.WriteLine("O resultado da divisão: {0}", resultado);
                }
                break;

            case 5:
                resultado = num1 % num2;
                Console.WriteLine("O resto da divisão é: {0}", resultado);
                break;

            case 6:
                for(int i = 0; i < num2; i++)
                {
                    resultado *= num1;
                }
                Console.WriteLine("O resto da potencialização é: {0}", resultado);
                break;

            case 0:
                break;
        }
    }
}

// Exercício 2 - Soma e Média
//Objetivo: usando uma aplicação do tipo console do dotnet, criar uma aplicação que lê 3 à
//10 números e realiza a soma e a média deles. 

//Novos conceitos ou funcionalidades desse exercício
//Faremos uso de loops e arrays no exercício, tente fazer o mesmo usando ´for´ e o ´foreach´.
//Faça o possível também para criar métodos que recebam parâmetros e retornem valores,
//dessa forma teremos uma codificação mais limpa e de fácil leitura.

//Estudar:
//● Criação de métodos
//● Receber parâmetros nos métodos
//● Retorno de valores nos métodos
//● Classe ´List´ do Dotnet
//● Loops ´for´ e ´foreach´

//Requisitos para desenvolver a aplicação
//● Ao abrir a aplicação deverá ser solicitado a quantidade de números que o usuário
//deseja informar. O número de valores deve ser entre 3 e 10.
//● A aplicação deve aceitar números decimais, positivos e negativos.
//● A aplicação deve percorrer a lista de números, calcular a soma e a média dos
//valores informados e imprimir o resultado para o usuário.

//Desafios
//1. Validar se os números digitados pelo usuário são validos (estude o TryParse para
//fazer esse desafio).
//2. Faça o uso da biblioteca "System.Linq" do Dotnet para fazer a soma (sum) e a
//média (average) da lista (array) de valores

static void Exer2(string[] args)
{
    int quantidade;

    Console.WriteLine("Quantidade de numeros que você ira colocar de 3 a 10 numeros");
    quantidade = Convert.ToInt32(Console.ReadLine());

    if (quantidade < 3 || quantidade > 10)
    {
        Console.WriteLine("Quantidade errada (3 a 10 numeros)");
    }
    else
    {
        List<double> listaNumeros = new List<double>();

        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine("\nEscreva o numero {0}:", i+1);
            double numeroTemp = Convert.ToDouble(Console.ReadLine());
            listaNumeros.Add(numeroTemp);
        }

        double soma = listaNumeros.Sum();
        double media = listaNumeros.Average();
        Console.WriteLine("A somatoria é {0}, a média é {1}", soma, media);

    }
}

//Exercício 3 - Jogar Dados
//Objetivo: usando uma aplicação do tipo console do dotnet, criar um jogo simplificado onde
//dois jogadores podem jogar dados e a aplicação informa qual dos jogadores tirou o maior
//número. Faça o controle de versionamento da sua aplicação com git e suba a mesma para
//o github.
//Novos conceitos ou funcionalidades desse exercício
//Usaremos nesse exercício a classe Random do dotnet para simular uma jogada de dados
//com 6 lados. O random irá possibilitar que tiremos um número aleatório (de 1 a 6 para
//nosso exemplo). Você pode usar loop para esse exercício, estude sobre loops caso não
//conheça. Poderá também optar por usar recursão (o exemplo de consulta usa recursão no
//método "IniciarRodadas"), recomendo estudar sobre recursão também antes de iniciar o
//exercício.
//Requisitos para desenvolver a aplicação
//● Quando o usuário abrir o jogo deverá ser solicitado o nome do primeiro e do
//segundo jogador. Não será possível jogar com mais do que dois jogadores.
//● O jogo deverá solicitar um nome para cada jogador e os nome não podem ser
//iguais.
//● O jogo terá 3 rodadas, o jogador que tirar o maior número no dados na maioria das
//jogadas vence a partida.
//● Em caso de empate (onde os dois tiram o mesmo número) nenhum jogador
//pontuará.
//● A cada rodada a aplicação deve informar quem foi o jogador vencedor. Exemplos de
//mensagens:
//○ João tirou o número 2 e Maria o número 6. Maria venceu a rodada 1.
//○ João tirou o número 1 e Maria o número 1. Empate.
//● Um placar sempre deve ser exibido até o final do jogo para que os jogadores
//acompanhem o resultado. Exemplo: Pontos do jogador Maria: 1 Pontos do jogador
//João: 0
//● Ao final da rodada 3 a aplicação deve informar quem foi o vencedor ou se foi um
//empate.
//Opcional
//● Fazer o controle de versionamento da sua aplicação usando git;
//● Subir a aplicação para um repositório do github.
//Desafios
//1. Se a terceira rodada terminar em empate, faça com que os jogadores continuem
//jogando dados. O próximo a pontuar ganha o jogo.
//2. Crie uma opção antes de iniciar o jogo que permite que o usuário selecione a
//quantidade de rodadas. A quantidade deve estar entre 1 e 5

static void analiseJogo(string jogador1, string jogador2,int dadoJog1, int dadoJog2, ref int placarJog1, ref int placarJog2)
{
    Console.WriteLine("\n{0} tirou {1} | {2} tirou {3}", jogador1, dadoJog1, jogador2, dadoJog2);

    if (dadoJog1 > dadoJog2)
    {
        placarJog1++;
        Console.WriteLine("{0} Ganhou!", jogador1);
    }
    else if (dadoJog1 < dadoJog2)
    {
        placarJog2++;
        Console.WriteLine("{0} Ganhou!", jogador2);
    }

    Console.WriteLine("\n{0} : {1} | {2} : {3}", jogador1, placarJog1, jogador2, placarJog2);
}

static void Exer3(string[] args)
{
    //iniciando variaveis com valores padroes
    string jogador1 = "a", jogador2 = "a";
    int numJogadas = 0;
    int dadoJog1, dadoJog2, placarJog1 =0, placarJog2=0;
    Random dados = new Random();

    while (jogador1 == jogador2)
    {
        Console.WriteLine("Quem é o primeiro jogador?");
        jogador1 = Console.ReadLine();

        Console.WriteLine("Quem é o primeiro jogador?");
        jogador2 = Console.ReadLine();

        if (jogador1 == jogador2)
        {
            Console.WriteLine("****Os nomes são iguais**** \n");
        }
    }

    while (numJogadas < 3 || numJogadas > 5)
    {
        Console.WriteLine("\nQual o numero de jogadas? (entre 3 a 5)");
        numJogadas = Convert.ToInt32(Console.ReadLine());
    }

    //Inicio do jogo

    for(int i = 1; i <= numJogadas; i++)
    {
        dadoJog1 = dados.Next(1, 101);
        dadoJog2 = dados.Next(1, 101);

        analiseJogo(jogador1, jogador2, dadoJog1, dadoJog2, ref placarJog1, ref placarJog2);

        if(i == numJogadas && placarJog1 == placarJog2)
        {
            while(placarJog1 == placarJog2)
            {
                dadoJog1 = dados.Next(1, 101);
                dadoJog2 = dados.Next(1, 101);

                analiseJogo(jogador1, jogador2, dadoJog1, dadoJog2, ref placarJog1, ref placarJog2);
            }
        }
    }

    if (placarJog1 > placarJog2)
        Console.WriteLine("{0} GANHOU !!! PARABENS", jogador1);
    else
        Console.WriteLine("{0} GANHOU !!! PARABENS", jogador2);
}

//Objetivo: usando uma aplicação do tipo console do dotnet, criar uma aplicação que listará
//algumas datas importante da área da técnologia, escolhar 5 datas ou utilize os sugeridos
//nos requisitos.

//Novos conceitos ou funcionalidades desse exercício
//Usaremos nesse exercício a classe DateTime do dotnet então antes ou durante o exercício
//estude sua documentação. Tente desenvolver o exercício criando uma classe chamada
//"DataConfiguracao" (você pode usar outro nome se preferir) a classe deverá conter os
//métodos responsáveis por configurar o formato escolhido, método para aplicar o formato da
//data, método para exibir o cabeçalho com a data no formato específicado, etc.
//Estude:
//● Classes, métodos, propriedades e construtores.
//● Modificadores de acesso: público, privado e protegido.
//● Retornando valores nos métodos.
//● Recebendo valores em atributos de métodos.
//Requisitos da aplicação
//● Quando o usuário abrir a aplicação deve ser solicitado qual o formato de data ele
//deseja visualizar. Deve ser disponibilizada as formatações abaixo:
//1.Utilizar minha configuração de sistema: 08 / 01 / 2021 20:48:13(Este item deve apenas
//converter a data para string, deixar que o sistema use o formato dele)
//2.Formato simples: 08 - 01 - 21
//3.Formato longo sexta-feira, 8 de janeiro de 2021
//4. Formato longo personalizado 08-01-2021 08:48:13
//5.Formato RFC1123 pattern Fri, 08 Jan 2021 20:48:13 GMT
//● Você deverá mostrar as datas conforme os formatos nos exemplos acima. Siga as
//dicas abaixo:
//○ Estude como usar o string.Format para personalizar o formato da data.
//○ Estude as conversões para string específicas para DateTime.
//○ Para o item 5, verifique como aplicar o formato RFC1123Pattern para o
//DateTime.
//● Na seleção do formato da data, valide a opção e exiba uma mensagem caso não
//esteja entre 1 e 5 conforme opções do primeiro requisito, e volte para o menu da
//seleção do formato da data para que o usuário tente novamente.
//● Após seleção correta de uma opção exiba um segundo menu com as seguintes
//opções (ou use outras de sua escolha): 1 - ENIAC 2 - RFC1 3 - Alan Turing
//● Ao escolher uma das opções o sistema deverá exibir para o usuário um cabeçalho
//com a data do evento e um texto com a descrição do evento. Abaixo você encontra
//as datas e textos dos eventos sugeridos acima:
//(ENIAC) - 15 de agosto de 1946 No dia 15 de agosto de 1946 os norte-americanos John
//Eckert e John Mauchly apresentaram o ENIAC, o primeiro equipamento eletrônico chamado
//de computador no mundo.
//(RFC1) - 17 de abril de 1969 Em 17 de abril de 1969 foi feita a publicação da RFC1, por
//esse motivo considera-se esse o dia da internet até hoje.
//(Alan Turing) - 23 de junho de 1912 Nascimento de Alan Turing, matemático e criptoanalista
//britânico que é considerado o "pai da informática" por ter sido essencial na criação de
//máquinas que, mais tarde, dariam origem aos PCs que utilizamos hoje para trabalhar,
//estudar e realizar nossas atividades diárias. Sua genialidade e influência fundamental na
//história da humanidade, entretanto, foram ceifadas pelo preconceito de uma época que,
//felizmente, já ficou para trás.
//1. Estude novos formatos de datas e aplique mais opções ao menu de escolha de
//formato de data.
//2. Estude a classe System.Globalization.CultureInfo e aplique novos formatos
//utilizando ela.

static void Exer4(string[] args)
{
    int numFor = 0;
    int evento = 0;

    while (numFor < 1 || numFor > 5)
    {
        Console.WriteLine("Escolha um formato de data:\n");
        Console.WriteLine("1 - Utilizar configuração do sisteman\n");
        Console.WriteLine("2 - Formato simples: dd - MM - yy\n");
        Console.WriteLine("3 - Formato longo: dia da semana, dia de mês de ano\n");
        Console.WriteLine("4 - Formato longo personalizado: dd-MM-yyyy HH:mm:ss\n");
        Console.WriteLine("5 - Formato RFC1123 pattern: ddd, dd MMM yyyy HH:mm:ss 'GMT'\n");
        Console.Write("Digite um número entre 1 e 5: \n");

        int.TryParse(Console.ReadLine(), out numFor);
    }

    while (evento < 1 || evento > 3)
    {
        Console.WriteLine("\nEscolha um evento histórico:\n");
        Console.WriteLine("1 - ENIAC\n");
        Console.WriteLine("2 - RFC1\n");
        Console.WriteLine("3 - Alan Turing\n");
        Console.Write("Digite um número entre 1 e 3: \n");

        int.TryParse(Console.ReadLine(), out evento);
    }
}

//Exercício 6 - Jogo da Forca
//Objetivo: usando uma aplicação do tipo console do dotnet, criar um jogo da forca que irá ler
//uma lista de nomes de filmes, nomes de jogos (vídeo game) e países. Com essa aplicação
//você poderá evoluir seus conhecimentos sobre manipulação de strings e leitura e escrita de
//arquivos.
//Novos conceitos ou funcionalidades desse exercício
//Gravação e leitura de arquivos para armazenar os nomes de filmes, carros e países.
//Estude:

//● Gravação e leitura de arquivos.
//● Orientação a objetos (encapsulamento, herança, abstração e polimorfismo).
//Caso não conheça os conceitos de orientação a objetos, pause um pouco a execução do
//exercício, estude esses conceitos e coloque-os em prática em alguns exemplos, pois no
//próximo exercício aprofundaremos em orientação a objetos.
//Requisitos da aplicação
//● Ao abrir a aplicação o sistema deverá sortear aleatoriamente uma das 3 categorias:
//filmes, carros ou países e, após isso, sortear um dos nomes da categoria
//selecionada.
//● Após a seleção feita pelo sistema, exiba um placar na tela com a quantidade de
//tentativas disponíveis e quantas tentativas já foram realizadas. Nesse mesmo placar
//crie uma lista com as letras e números já utilizados pelo jogador.
//● Mostre na tela também, a categoria sorteada e a quantidade de letras da palavra.
//Além da quantidade de letras, inicialmente todas as letras da palavra devem ser
//substituídas por underline (_). Exemplo:
//○ Se a palavra for o filme Matrix, deverá ser exibido 6 underline no lugar da
//palavra.

//○ Ao acertar a letra A, deverá ser exibido apenas a letra a na posição correta.
//● As palavras devem ficar armazenadas em um arquivo de texto do tipo CSV que terá
//a palavra seguido pela categoria, onde Filme = 0, Jogo = 1, e Pais = 2. Segue um
//exemplo de como cada tipo deve ficar no arquivo:
//○ Matrix; 0;
//○ Batman; 1;
//○ Brasil; 2;

//● Se alguma palavra possui letra com acentuação, ela deve ser reconhecida quando o
//usuário informar sem acentuação, além disso a aplicação não deve diferenciar
//maiúsculo de minúsculo. Estude como usar o System.Text.Encoding.CodePages
//para remoção de acentos usando o 'ISO-8859-8'.
//● A cada tentativa atualize o placar com as pontuações.
//● Caso o jogador a 0 no número de tentativas exiba a mensagem "Fim de jogo, você
//perdeu!".
//● Caso o jogador acerte todas as letras, exiba a mensagem "Fim de jogo, você
//venceu!".
//Opcional
//● Fazer o controle de versionamento da sua aplicação usando git;
//● Subir a aplicação para um repositório do github.
//● Faça o uso de todos os pilares da programação Orientada a Objetos.
//● Utilize Enumeradores para a categoria das palavras.
//● Estude o tratamento de erros com C# (Exceptions).
//● Estude a biblioteca System.Linq; para facilitar sua manipulação de listas.

//Desafios
//1. Crie mais uma categoria para o jogo dê sua preferência.
//2. Antes de iniciar o jogo dê a opção de o usuário escolher a dificuldade do jogo: fácil,
//normal ou difícil:
//○ Fácil: 7 tentativas
//○ Normal: 6 tentativas
//○ Difícil: 5 tentativas

static void Exer6(string[] args)
{

}

Exer3(args);