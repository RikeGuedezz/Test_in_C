/*
Crie uma matriz de inteiros com 4 linhas e 4 colunas. Inicialize a matriz com
valores inteiros de sua escolha e, em seguida, exiba apenas os valores pares
da matriz.
 */
using System;

namespace G01
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[,] matriz = new int[4,4];
			Random randan = new Random();
			
			for(int l = 0; l < 4; l++){
				for(int c = 0; c < 4; c++){
					matriz[l,c] = randan.Next(0,100);
				}
			}
			
			
			for(int l = 0; l < 4; l++){
				for(int c = 0; c < 4; c++){
					Console.Write(matriz[l,c] + " ");
				}
				Console.WriteLine();
			}
			
			Console.WriteLine("");
			Console.WriteLine("\n");
			Console.WriteLine("Os numeros pares da matriz, abaixo");
			
			for(int l = 0; l < 4; l++){
				for(int c = 0; c < 4; c++){
					if (matriz[l,c] % 2 == 0)
					{
					Console.Write(matriz[l,c] + " ");
					}
				}
				Console.WriteLine("");
			}
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}