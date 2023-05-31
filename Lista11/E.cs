/*
Crie um método que receba uma lista de strings como parâmetro e retorne uma
única string que contém todos os elementos da lista concatenados.
 */
using System;
using System.Collections.Generic;
namespace E50
{
	class Program
	{
		static string metodo (List<string> lista)
		{
			string varnv  = "";
			for (int cont = 0; cont < 4; cont++){
				varnv += lista[cont];
			}
			return varnv;
			
		}
		
		public static void Main(string[] args)
		{
			
			List<string> lista = new List<string>{
			"Rikelme", "Leandro", "Santos", "Guedes"
			};
			
			
			Console.WriteLine(metodo(lista));
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}