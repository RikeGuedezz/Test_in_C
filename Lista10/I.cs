/*
Criar um algoritmo que leia os elementos de uma matriz inteira 10x10. Some
todos os valores da matriz.
 */
using System;

namespace I01
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[,] matriz = new int[10,10];
			Random randan = new Random();
			int soma = 0;
			
			for(int l = 0; l < 10; l++){
				for(int c = 0; c < 10; c++){
					matriz[l,c] = randan.Next(1,200);
				}
			}
			
			for(int l = 0; l < 10; l++){
				for(int c = 0; c < 10; c++){
					soma+= matriz[l,c];
				}
			}
			Console.WriteLine(soma);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}