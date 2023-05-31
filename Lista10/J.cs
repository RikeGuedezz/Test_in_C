/*
Faça um programa que carregue:

Um vetor de oito posições com os nomes das lojas;
Um outro vetor com quatro posições com os nomes dos produtos;
Uma matriz com os preços de todos os produtos em cada loja.

O programa deve mostrar todas as relações (nome do produto - nome da loja
- preço) nas quais o preço não ultrapasse R$ 120,00.
 */
 
using System;

namespace J01
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			
		string[] nomesLojas = new string[8] { "Loja A", "Loja B", "Loja C", "Loja D", "Loja E", "Loja F", "Loja G", "Loja H" };
        string[] nomesProdutos = new string[4] { "Produto 1", "Produto 2", "Produto 3", "Produto 4" };
        decimal[,] precosProdutos = new decimal[4, 8]
        {
            { 100.50m, 150.20m, 80.90m, 120.30m, 90.75m, 200.00m, 110.50m, 115.80m },
            { 90.00m, 130.40m, 140.60m, 95.30m, 110.20m, 170.90m, 105.40m, 140.10m },
            { 80.50m, 120.60m, 115.20m, 100.75m, 85.60m, 140.30m, 95.90m, 130.00m },
            { 95.80m, 110.30m, 105.40m, 75.90m, 130.50m, 90.20m, 125.40m, 100.80m }
        };

        Console.WriteLine("Relações de produtos e lojas com preço abaixo de R$ 120,00:");

        for (int i = 0; i < nomesProdutos.Length; i++)
        {
            for (int j = 0; j < nomesLojas.Length; j++)
            {
                if (precosProdutos[i, j] <= 120.00m)
                {
                    Console.WriteLine("Produto: {0} - Loja: {1} - Preço: R$ {2}", nomesProdutos[i], nomesLojas[j], precosProdutos[i, j]);
                }
            }
        }
			
			
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}