/*
Crie uma matriz de inteiros com 3 linhas e 3 colunas. Inicialize a matriz com
valores inteiros aleatórios entre 1 e 100 e, em seguida, encontre o maior
valor da matriz.
 */
using System;

namespace F01
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[,] matriz = new int[3,3];
			matriz[0,0] = 23;
			matriz[0,1] = 43;
			matriz[0,2] = 31;
			matriz[1,0] = 12;
			matriz[1,1] = 15;
			matriz[1,2] = 2;
			matriz[2,0] = 1;
			matriz[2,1] = 6;
			matriz[2,2] = 76;
			int mostra = matriz[0,0];
			
			for(int l = 0; l < 3; l++){
				for(int c = 0; c < 3; c++){
					if(matriz[l,c] > mostra){
						mostra = matriz[l,c];
					}
				}
			}
			
			Console.WriteLine("Maior Valor é {0} ",mostra);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}