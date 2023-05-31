/*
Crie um algoritmo que armazene nome e duas notas de 5 alunos e imprima
uma listagem contendo nome, as duas notas e a média de cada aluno.
 */
using System;

namespace B
{
	class Program
	{
		public static void Main(string[] args)
		{
			string[] nome ={ "Rikelme","Luiz","Ana","Pedro","Bernado" };
			int[] nota1 ={ 21,10,10,10,10 };
			int[] nota2 ={ 25,10,10,10,10 };
			double[] med = new double[5];
			
			for ( int i = 0; i < med.Length; i++ ){
				med[i] = (nota1[i] + nota2[i])/2;
				Console.Write(nome[i]);
				Console.Write(" "+med[i]);
				Console.Write(", ");
			}
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}