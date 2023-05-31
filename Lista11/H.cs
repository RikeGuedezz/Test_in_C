/*
Crie um método que receba uma lista de números inteiros como parâmetro e
retorne a média dos números.
 */
using System;
using System.Collections.Generic;
namespace HH
{
	class Program
	{
		static double metodo (List<double> lista)
		{
			double recebe = 0;
			//int media = recebe/lista.Count;
			//return media;
			
			for (int i = 0; i < lista.Count; i++){
				recebe += lista[i];
			}
			
			double media = recebe / lista.Count;
			return media;
			
		}
		
		public static void Main(string[] args)
		{
			List<double> lista = new List<double>();
			lista.Add(2);
			lista.Add(6);
			lista.Add(20);
			lista.Add(12);
			
			double media = metodo(lista);
			
			
			Console.WriteLine(media);
			//Console.WriteLine();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}