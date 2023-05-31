/*
Crie um método que receba uma lista de números inteiros como parâmetro e
retorne o maior número da lista.
 */
using System;
using System.Collections.Generic;
namespace A40
{
	class Program
	{
		
		static int metodo (List<int> lista)
		{
			int maior = lista[0];
				
				foreach (int valor in lista)
				{
					if (valor > maior){
						maior = valor;
					}
				}
				return maior;
				
		}
		
		public static void Main(string[] args)
		{
			
			List<int> lista = new List<int>{
			1,2,3,4,5,6,7,8,9,10
			};
			
			
			Console.WriteLine(metodo(lista));
			
			
			
			
			
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}