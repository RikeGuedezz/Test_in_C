/*
Crie um método que receba um número inteiro como parâmetro e retorne seu
quadrado.
 */
using System;

namespace A10
{
 class Program
  
 {
  
  
 // static tipo nome_Metodo ( <tipo> variavel)
 
 
 static int Metodo (int var1)
  {
  return var1 * var1;
   
  }
  
  
  
  public static void Main(string[] args)
  {
   int n1;
   
   
   Console.WriteLine("Digite um numero agora!");
   n1 = int.Parse(Console.ReadLine());
   
   Console.WriteLine(Metodo(n1));

			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}