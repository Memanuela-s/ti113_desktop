namespace Segundo_Programa
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("1. Soma");
            Console.WriteLine("2. Subtração");
            Console.WriteLine("3. Multiplicação");
            Console.WriteLine("4. Divisão");
            Console.WriteLine("5. Potenciação");
            Console.WriteLine("6. Radiciação");

            Console.Write("Digite a opção desejada: ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            double num1 = 0, num2 = 0, resultado = 0;

            if (opcao >= 1 && opcao <= 5)
            {
                Console.Write("Digite o primeiro número: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                num2 = Convert.ToDouble(Console.ReadLine());
            }
            else if (opcao == 6)
            {
                Console.Write("Digite o número para radiciação: ");
                num1 = Convert.ToDouble(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Opção inválida!");
                return;
            }

            switch (opcao)
            {
                case 1:
                    resultado = num1 + num2;
                    Console.WriteLine($"Resultado: {num1} + {num2} = {resultado}");
                    break;
                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine($"Resultado: {num1} - {num2} = {resultado}");
                    break;
                case 3:
                    resultado = num1 * num2;
                    Console.WriteLine($"Resultado: {num1} x {num2} = {resultado}");
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Erro: Divisão por zero não permitida!");
                    }
                    else
                    {
                        resultado = num1 / num2;
                        Console.WriteLine($"Resultado: {num1} / {num2} = {resultado}");
                    }
                    break;
                case 5:
                    resultado = Math.Pow(num1, num2);
                    Console.WriteLine($"Resultado: {num1}^{num2} = {resultado}");
                    break;
                case 6:
                    if (num1 < 0)
                    {
                        Console.WriteLine("Erro: Não é possível calcular raiz de número negativo!");
                    }
                    else
                    {
                        resultado = Math.Sqrt(num1);
                        Console.WriteLine($"Resultado: √{num1} = {resultado}");
                    }
                    break;
            }
        }
    }
}