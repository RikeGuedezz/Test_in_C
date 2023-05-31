/*
Crie um método que receba um número inteiro como parâmetro e retorne
verdadeiro se o número for primo e falso caso contrário.
 */
using System;

namespace II
{
	class Program
	{
		static bool metodo (int var1){			
			
			if(var1 < 2){
				return false;
			}
			
			for( int i = 2; i <=Math.Sqrt(var1); i++ ){
				if( var1 % i == 0 ){
					return false;
				}
			}
			
			return true;
		}
		
		
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite um numero");
			int var1 = int.Parse(Console.ReadLine());
	
			bool resut = metodo(var1);
			
			Console.WriteLine(resut8);


			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}