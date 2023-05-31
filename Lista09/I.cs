/*
Crie um algoritmo que entre com 10 nomes e imprima uma listagem
contendo todos os nomes.
 */
using System;

namespace I
{
	class Program
	{
		public static void Main(string[] args)
		{
			string[] nomes = {"Rikelme", "Leandro", "Luan", "Luiz", "Ana", "Mateus", "Ryan", "Tadeu", "Habby", "Kelly"};
			
			for( int i = 0; i < nomes.Length; i++ ){
				Console.WriteLine(nomes[i]);
				
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}