using System;

namespace Atv0F
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*Escreva um programa que pergunte ao usuário sua idade e se tem carteira de
			motorista. Se o usuário tiver mais de 18 anos e possuir carteira de motorista,
						o programa deve imprimir "Você pode dirigir".*/
			
			//Var
			int idade;
			string cnh;
			
			//Entrada
			Console.WriteLine("Quantos Anos o Usuário tem? ");
			idade = int.Parse(Console.ReadLine());
			Console.WriteLine("Você tem CNH? s/n");
			cnh = Console.ReadLine();
				
			//Saida
			
			
			
			//Calculo
			if (idade > 18 && cnh == "s")
			{
				Console.WriteLine("Você pode Dirigir Carrinhos de Rolimã");
			} else
			{
				Console.WriteLine("Não Pode DIRIGIR DIN DIN DIN DIN RAN RAN RAN RAN PA PA PA");
			}
			
			
				
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}