/*
Crie um algoritmo que armazene números em dois vetores inteiros de cinco
elementos cada. Gere e imprima o vetor soma.
 */
using System;

namespace F
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[] n1 = {12,12,23,43,2};
			int[] n2 = {23,1,43,1,7};
			int[] soma = new int[5];
			
			for (int i = 0; i < soma.Length; i++){
				soma[i] = n1[i] + n2[i];
				Console.WriteLine("Soma de {0} + {1} = {2}", n1[i],n2[i],soma[i]);
			
			}
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}