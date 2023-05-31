/*

 */
using System;

namespace E
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[] maior = new int[1];
			int[] menor = new int[12];
			
			
			for( int i = 0; i < maior.Length; i++ ){
			string ternario = ( maior[i] > menor[i] ) ? "1º numero maior" : "2º numero maior";
				Console.WriteLine(ternario);
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}