using System;

namespace G
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*Crie um programa que solicite ao usuário para inserir um número inteiro
			positivo e, em seguida, exiba todos os números pares entre 0 e o número
										inserido.*/
	
			int n1;
			int n0 = 0;
			
			Console.WriteLine("Digite um numero positivo");
				n1 = int.Parse(Console.ReadLine());
				
			do
			{
				Console.Write(n0);
				Console.Write(",");
				n0+=2;
			}
			while(n0 <= n1);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}