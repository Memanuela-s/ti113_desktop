namespace Setimo_Programa
{
    class Program
    {
        static void Main()
        {
            string nomeMaisBarato = "";
            double precoMaisBarato = double.MaxValue;

            for (int i = 1; i <= 6; i++)
            {
                Console.Write($"Digite o nome do {i}º produto: ");
                string nomeProduto = Console.ReadLine();

                Console.Write($"Digite o preço do {i}º produto: ");
                double precoProduto = Convert.ToDouble(Console.ReadLine());

                if (precoProduto < precoMaisBarato)
                {
                    precoMaisBarato = precoProduto;
                    nomeMaisBarato = nomeProduto;
                }
            }

            Console.WriteLine($"\nO produto mais barato é: {nomeMaisBarato} custando R$ {precoMaisBarato:F2}");
        }
    }
}