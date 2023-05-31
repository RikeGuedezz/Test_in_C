using System;

namespace H
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*Desenvolva um programa que solicite ao usuário para inserir um número
			 inteiro e, em seguida, exiba a tabuada desse número até o número 10.*/
			
			int n2 = 0;
			int n1,n3;
			
			Console.WriteLine("Digite um numero Positivo ate 10");
			n1 = int.Parse(Console.ReadLine());
			
			do
			{
				n2++;
				n3 = n1*n2;
				Console.WriteLine("{0} * {1} = {2}",n1,n2,n3);
				
			}
			while (n2 <= 9);
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}