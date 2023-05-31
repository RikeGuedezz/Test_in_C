/*
Crie um vetor de inteiros e ordene os valores do vetor em ordem decrescente.
 */
using System;

namespace H
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[] desc = {12,13,14,15};
			Array.Reverse(desc);
			
			for(int i = 0; i < desc.Length; i++){
				Console.Write(desc[i]);
				Console.Write(",");
			}
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}