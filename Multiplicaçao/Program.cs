namespace Multiplicacao
{
    using System;

    class Program
    {
        static void Main()
        {
            int numero1, numero2;

            // Solicita e valida o primeiro número
            while (true)
            {
                Console.Write("Digite o primeiro número: ");
                if (int.TryParse(Console.ReadLine(), out numero1))
                    break;
                else
                    Console.WriteLine("Entrada inválida! Por favor, insira um número inteiro.");
            }

            // Solicita e valida o segundo número
            while (true)
            {
                Console.Write("Digite o segundo número: ");
                if (int.TryParse(Console.ReadLine(), out numero2))
                    break;
                else
                    Console.WriteLine("Entrada inválida! Por favor, insira um número inteiro.");
            }

            // Calcula e exibe a multiplicação
            double multiplicacao = (double)numero1 * numero2;
            Console.WriteLine($"A multiplicação de {numero1} por {numero2} é: {multiplicacao:F2}");
        }
    }
}

