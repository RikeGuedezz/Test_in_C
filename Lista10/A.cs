/*

 */
using System;

namespace A1
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int[,]matriz = new int[3,3];
			
			for (int i = 0; i < 3; i++){
				for(int j = 0; j < 3; j++){
					Console.Write(matriz[i,j] + " ");
				}
				Console.WriteLine();
			}
			
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}