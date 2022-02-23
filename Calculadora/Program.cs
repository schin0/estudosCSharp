using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            DefinirOperacao();
        }

        static void DefinirOperacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Escolha qual operação desejar:");
            Console.WriteLine("1 - Soma(+):");
            Console.WriteLine("2 - Subtração(-):");
            Console.WriteLine("3 - Multiplicação(*):");
            Console.WriteLine("4 - Divisão(/):");
            Console.WriteLine("5 - Sair do programa:");
            short operacao = short.Parse(Console.ReadLine());
            Console.WriteLine("");

            switch (operacao)
            {
                case 1:
                    Soma(valor1, valor2);
                    break;

                case 2:
                    Subtracao(valor1, valor2);
                    break;

                case 3:
                    Multiplicacao(valor1, valor2);
                    break;

                case 4:
                    Divisao(valor1, valor2);
                    break;

                case 5:
                    System.Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Escolha uma operação válida!");
                    Console.ReadKey();
                    DefinirOperacao();
                    break;
            }
        }

        // Método Soma
        static void Soma(float valor1, float valor2)
        {
            float soma = valor1 + valor2;
            Console.WriteLine($"O resultado da SOMA é: {soma}");
            Console.ReadKey();
            DefinirOperacao();
        }

        // Método Subtração
        static void Subtracao(float valor1, float valor2)
        {
            float subtracao = valor1 - valor2;
            Console.WriteLine($"O resultado da SUBTRAÇÃO é: {subtracao}");
            Console.ReadKey();
            DefinirOperacao();
        }

        // Método Multiplicação
        static void Multiplicacao(float valor1, float valor2)
        {
            float multiplicacao = valor1 * valor2;
            Console.WriteLine($"O resultado da SOMA é: {multiplicacao}");
            Console.ReadKey();
            DefinirOperacao();
        }

        // Método Divisão
        static void Divisao(float valor1, float valor2)
        {
            float divisao = 0;

            if (valor1 > valor2)
            {
                if (valor2 != 0)
                {
                    divisao = valor1 / valor2;
                    Console.WriteLine($"O resultado da DIVISÃO é: {divisao}");
                    Console.ReadKey();
                    DefinirOperacao();
                }
                else
                {
                    Console.WriteLine("Não existe divisão por zero!");
                    Console.ReadKey();
                    DefinirOperacao();
                }
            }
            else if (valor2 > valor1)
            {
                if (valor1 != 0)
                {
                    divisao = valor2 / valor1;
                    Console.WriteLine($"O resultado da DIVISÃO é: {divisao}");
                    Console.ReadKey();
                    DefinirOperacao();
                }
                else
                {
                    Console.WriteLine("Não existe divisão por zero!");
                    Console.ReadKey();
                    DefinirOperacao();
                }
            }
        }
    }
}
