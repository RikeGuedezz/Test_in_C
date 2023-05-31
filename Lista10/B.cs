/*

 */
using System;

namespace B1
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int[,] matriz = new int[10,10];
			
			for(int i = 0; i < 10; i++){
				for(int j = 0; j < 10; j++){

						//Console.Write(matriz[i,j] + " ");
						if(i == j){
							Console.Write(matriz[i,j]+" ");
						}else{
							Console.Write(" ");
						}
				}
				Console.WriteLine();
			}
			
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}