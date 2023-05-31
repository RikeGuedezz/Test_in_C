/*
 Criar um algoritmo que leia os elementos de uma matriz inteira 10x10 e
imprima os elementos da matriz.

Calcule e mostre a soma e a média da diagonal principal.
Calcule e mostre a soma e a média da diagonal secundária.

 */
using System;

namespace H01
{
	class Program
	{
		public static void Main(string[] args)
		{
			//VARIAVEIS
			int[,] matriz = new int[10,10];
			Random randan = new Random();
			int soma = 0; 
			int soma2 = 0;
			
			
			//ENTRADA
			for(int l = 0; l < 10; l++){
				for(int c = 0; c < 10; c++){
					matriz[l,c] = randan.Next(1,200);
				}
			}
			
			
			for(int l = 0; l < 10; l++){
				for(int c = 0; c < 10; c++){
					Console.Write(matriz[l,c] + "\t");
				}
				Console.WriteLine("");
			}
			
			//SOMA PRINCIPAL
			for(int l = 0; l < 10; l++){
				for(int c = 0; c < 10; c++){
					if(l == c){
						soma += matriz[l,c];
						//Console.WriteLine("Soma da principal {0} ", soma);
					}
				}
			}
			Console.WriteLine("Soma da principal {0} ", soma);
			
			//SOMA SECUNDARIA
			for(int l = 0; l < 10; l++){
				for(int c = 0; c < 10; c++){
					if((l + c) == 9){
						soma2 += matriz[l,c];
						//Console.WriteLine("Soma da secundaria {0} ", soma2);
					}
				}
			}
			Console.WriteLine("Soma da secundaria {0} ", soma2);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}