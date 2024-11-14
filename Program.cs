using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Menu();

        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que você gostaria de fazer?");
            Console.WriteLine("1. Soma");
            Console.WriteLine("2. Subtração");
            Console.WriteLine("3. Multiplicação");
            Console.WriteLine("4. Divisão");
            Console.WriteLine("5. Sair");
            Console.WriteLine("");
            Console.WriteLine("Digite sua escolha: ");
            string choice = Console.ReadLine() ?? string.Empty;

            switch (choice) // Avalia a escolha do usuário e executa a operação correspondente
            {
                case "1":
                    Soma();
                    break;
                case "2":
                    Subtracao();
                    break;
                case "3":
                    Multiplicacao();
                    break;
                case "4":
                    Divisao();
                    break;
                case "5":
                    Console.WriteLine("Adeus!");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: "); // Adiciona verificação para null
            float first = float.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Segundo Valor: "); // Adiciona verificação para null
            float second = float.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("");

            float resultado = first + second;
            Console.WriteLine($"O resultado da soma é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()

        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor:");
            float first = float.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Segundo Valor: ");
            float second = float.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("");

            float resultado = first - second;
            Console.WriteLine($"O Resultado da subtração é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            float first = float.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Segundo Valor: ");
            float second = float.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("");
            float resultado = first / second;
            Console.WriteLine($"O resultado da divisão é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            float first = float.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Segundo Valor: ");
            float second = float.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("");
            float resultado = first * second;
            Console.WriteLine($"O resultado da multiplicação é: {resultado}");
            Console.ReadKey();
            Menu();
        }




    }



}