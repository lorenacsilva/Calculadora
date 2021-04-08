using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, resultado;
            string operacao;

            Console.WriteLine("Digite um número:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite operação desejada:");
            operacao = Console.ReadLine();

            if (operacao == "Soma" || operacao == "+" || operacao == "Adição")
            {
                resultado = adicao(a, b);
                Console.WriteLine($"{a} + {b} = {resultado}");
            }

            else if (operacao == "Menos" || operacao == "-" || operacao == "Subtração")
            {
                resultado = subtracao(a, b);
                Console.WriteLine($"{a} - {b} = {resultado}");
            }

            else if (operacao == "Vezes" || operacao == "*" || operacao == "Multiplicação")
            {
                resultado = multiplicacao(a, b);
                Console.WriteLine($"{a} * {b} = {resultado}");
            }

            else if (operacao == "Dividido" || operacao == "/" || operacao == "Divisão")
            {
                resultado = divisao(a, b);
                Console.WriteLine($"{a} / {b} = {resultado}");
            }

            else
                Console.WriteLine("Operação Invalida!");

        }

        // Métodos

        static int adicao(int a, int b)
        {
            int result = a + b;
            return result;
        }

        static int subtracao(int a, int b)
        {
            int result = a - b;
            return result;
        }

        static int divisao(int a, int b)
        {
            int result = a / b;
            return result;
        }

        static int multiplicacao(int a, int b)
        {
            int result = a * b;
            return result;
        }
    }
}
