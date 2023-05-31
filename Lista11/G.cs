/*
 Crie um método que receba uma string como parâmetro e retorne uma nova string
contendo apenas os caracteres em posições ímpares.
 */
using System;

namespace G70
{
	class Program
	{
		static string metodo (string nome)
		{
			// nova string para receber o "nome"
			string result = "";
			
			//usando "for" para dar inicio ao parametro de retorno de string usando o if dentro para ter sua condição
			for(int i = 0; i < nome.Length; i++ ){
				if (i %2 != 0){
					result += nome[i];
				}
				
			}
			//return fora do "for e if" para assim retorna o resultado
   			return result;
			
		}
		
		
		public static void Main(string[] args)
		{
			//aderindo um nome a variavel
			string nome1 = "Paralelepipedo";
			
			//printando ela
			Console.WriteLine(metodo(nome1));
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}