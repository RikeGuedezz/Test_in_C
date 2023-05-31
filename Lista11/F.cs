/*
Crie um método que receba um número inteiro como parâmetro e retorne
verdadeiro se o número for par e falso se o número for ímpar.
 */
using System;

namespace F60
{
	class Program
	{
		static bool VerificaParImpar(int numero)
		{
			if (numero % 2 == 0){
				return true;
			}
			else{
				return false;
			}
		}
		
		
		public static void Main(string[] args)
		{
			int numero;
			bool retorno;
			
			Console.WriteLine("Digite um Numero");
			numero = int.Parse(Console.ReadLine());
			
			retorno = VerificaParImpar(numero);
			
			if (retorno == true) {
				Console.WriteLine("Par");
			}else{
				Console.WriteLine("Impar");
			}
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}