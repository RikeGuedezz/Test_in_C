/*
 Crie uma matriz de números decimais com 2 linhas e 2 colunas. Inicialize a
matriz com valores decimais de sua escolha e, em seguida, calcule a média
dos valores da matriz.
 */
using System;

namespace E01
{
	class Program
	{
		public static void Main(string[] args)
		{
			decimal[,] matriz = new decimal[2,2];
			matriz[0,0] = 12; 
			matriz[0,1] = 43; 
			matriz[1,0] = 32; 
			matriz[1,1] = 87;
			
			int[,] media = new int[2,2];
			decimal deci = 0;
			
			for(int l = 0; l < 2; l++){
				for(int c = 0; c < 2; c++){
					Console.Write(matriz[l,c]+ " ");
				}
			Console.WriteLine();
			}
			
			for(int l = 0; l < 2; l++){
				for(int c = 0; c < 2; c++){
					deci+= matriz[l,c]/2;
				}
			}
			Console.WriteLine("Media da matriz é {0}",deci);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}