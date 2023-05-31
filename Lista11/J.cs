/*
Crie um método que receba uma lista de números inteiros como parâmetro e
retorne o menor número da lista
 */
using System;
using System.Collections.Generic;
namespace JJ
{
	class Program
	{
		static int metodo (List<int> recebe){
		
			//fazer o menor receber a lista 
			int menor = recebe [0];
			
			//aqui fazer com que o foreach procure numero na lista 
			foreach (int numero in recebe)
				{
				//com o if vamos pegar o menor numero 
					if (numero < menor){
						menor = numero;
					}
				}
			//retornando
				return menor;
			
			
		
		}
		public static void Main(string[] args)
		{
			
			
			List<int> recebe = new List<int>();
			recebe.Add(4);
			recebe.Add(12);
			recebe.Add(43);
			recebe.Add(31);
			recebe.Add(22);
			recebe.Add(6);
			recebe.Add(1);
			
			Console.WriteLine(metodo(recebe));
			Console.WriteLine();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}