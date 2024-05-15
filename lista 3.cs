/*using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicita e lê o número do funcionário
        Console.WriteLine("Digite o número do funcionário:");
        int numeroFuncionario = int.Parse(Console.ReadLine());

        // Solicita e lê o número de horas trabalhadas
        Console.WriteLine("Digite o número de horas trabalhadas:");
        int horasTrabalhadas = int.Parse(Console.ReadLine());

        // Solicita e lê o valor por hora
        Console.WriteLine("Digite o valor que o funcionário recebe por hora:");
        double valorPorHora = double.Parse(Console.ReadLine());

        // Calcula o salário do funcionário
        double salario = horasTrabalhadas * valorPorHora;

        // Mostra o número e o salário do funcionário
        Console.WriteLine($"Número do funcionário: {numeroFuncionario}");
        Console.WriteLine($"Salário: {salario}");
    }
}*/
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicita e lê os dados da peça 1
        Console.WriteLine("Digite o código da peça 1, o número de peças 1 e o valor unitário de cada peça 1 (separados por espaço):");
        string[] dadosPeca1 = Console.ReadLine().Split(' ');
        int codigoPeca1 = int.Parse(dadosPeca1[0]);
        int numeroPecas1 = int.Parse(dadosPeca1[1]);
        double valorUnitarioPeca1 = double.Parse(dadosPeca1[2]);

        // Solicita e lê os dados da peça 2
        Console.WriteLine("Digite o código da peça 2, o número de peças 2 e o valor unitário de cada peça 2 (separados por espaço):");
        string[] dadosPeca2 = Console.ReadLine().Split(' ');
        int codigoPeca2 = int.Parse(dadosPeca2[0]);
        int numeroPecas2 = int.Parse(dadosPeca2[1]);
        double valorUnitarioPeca2 = double.Parse(dadosPeca2[2]);

        // Calcula o valor total a ser pago
        double valorTotalPagar = (numeroPecas1 * valorUnitarioPeca1) + (numeroPecas2 * valorUnitarioPeca2);

        // Mostra o valor a ser pago
        Console.WriteLine($"VALOR A PAGAR: {valorTotalPagar.ToString("F2")}");
    }
}
*/

/*using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicita e lê os valores de A, B e C
        Console.WriteLine("Digite os valores de A, B e C (separados por espaço):");
        string[] valores = Console.ReadLine().Split(' ');
        double A = double.Parse(valores[0]);
        double B = double.Parse(valores[1]);
        double C = double.Parse(valores[2]);

        // Calcula e mostra a área do triângulo retângulo
        double areaTriangulo = A * C / 2.0;
        Console.WriteLine($"TRIANGULO: {areaTriangulo.ToString("F2")}");

        // Calcula e mostra a área do círculo
        double areaCirculo = 3.14159 * C * C;
        Console.WriteLine($"CIRCULO: {areaCirculo.ToString("F5")}");

        // Calcula e mostra a área do trapézio
        double areaTrapezio = (A + B) / 2.0 * C;
        Console.WriteLine($"TRAPEZIO: {areaTrapezio.ToString("F2")}");

        // Calcula e mostra a área do quadrado
        double areaQuadrado = B * B;
        Console.WriteLine($"QUADRADO: {areaQuadrado.ToString("F2")}");

        // Calcula e mostra a área do retângulo
        double areaRetangulo = A * B;
        Console.WriteLine($"RETANGULO: {areaRetangulo.ToString("F2")}");
    }
}
*/
/*using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicita e lê o login e a senha do usuário
        Console.WriteLine("Digite o login:");
        string login = Console.ReadLine();
        Console.WriteLine("Digite a senha:");
        string senha = Console.ReadLine();

        // Verifica se o login e a senha estão corretos
        if (login == "admin" && senha == "1234")
        {
            Console.WriteLine("Pode acessar");
        }
        else
        {
            Console.WriteLine("Login ou senha incorreto");
        }
    }
}
*/

/*using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicita e lê a quantidade de blusas em estoque
        Console.WriteLine("Digite a quantidade de blusas em estoque:");
        int quantidade = int.Parse(Console.ReadLine());

        // Verifica a quantidade em estoque e exibe a mensagem correspondente
        if (quantidade > 40)
        {
            Console.WriteLine("ESTOQUE OK");
        }
        else if (quantidade > 20 && quantidade <= 40)
        {
            Console.WriteLine("ATENÇÃO AO ESTOQUE");
        }
        else
        {
            Console.WriteLine("ESTOQUE CRÍTICO");
        }
    }
}*/

/*using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicita e lê a idade e o salário do usuário
        Console.WriteLine("Digite a idade:");
        int idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o salário:");
        double salario = double.Parse(Console.ReadLine());

        // Verifica se o usuário atende aos requisitos para obter o visto
        if (idade >= 18 && salario > 2000)
        {
            Console.WriteLine("PODE VIAJAR");
        }
        else
        {
            Console.WriteLine("NÃO PODE VIAJAR");
        }
    }
}*/

/*using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicita e lê o número escolhido pelo aluno
        Console.WriteLine("Digite o número da aula escolhida:");
        int numeroAula = int.Parse(Console.ReadLine());

        // Verifica o número escolhido e exibe a aula correspondente
        switch (numeroAula)
        {
            case 1:
            case 2:
                Console.WriteLine("DESENHO E PINTURA");
                break;
            case 3:
            case 4:
                Console.WriteLine("DISCURSO E DEBATE");
                break;
            default:
                Console.WriteLine("DANÇA");
                break;
        }
    }
}
*/
/*using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicita e lê o número digitado pelo usuário
        Console.WriteLine("Digite um número:");
        int numero = int.Parse(Console.ReadLine());

        // Verifica se o número é positivo e maior que 100 ao mesmo tempo
        if (numero > 0 && numero > 100)
        {
            Console.WriteLine("Número especial");
        }
        else
        {
            Console.WriteLine("Fora do intervalo");
        }
    }*/
}



