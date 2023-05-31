/*
Criar um algoritmo que leia os elementos de uma matriz inteira 10x10 os
elementos, exceto os elementos da diagonal principal.
 */
using System;

namespace D01
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[,] matriz = new int[10,10];
			
			for(int l = 0; l < 10; l++){
				for(int c = 0; c < 10; c++){
					if(l == c){
						Console.Write("  ");
						}else{
							Console.Write(matriz[l,c]+" ");
						}
				}
				Console.WriteLine("");
			}
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}