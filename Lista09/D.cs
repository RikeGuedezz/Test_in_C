/*
 Crie um vetor de inteiros e encontre o maior valor no vetor
 */
using System;

namespace D
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int[] maior = new int[1];
			int[] menor = new int[6];
			
			
			for( int i = 0; i < maior.Length; i++ ){
			string ternario = ( maior[i] < menor[i] ) ? "1º numero menor" : "2º numero maior";
				Console.WriteLine(ternario);
			}
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}