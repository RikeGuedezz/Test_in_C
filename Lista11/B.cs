/*Crie um método que receba uma string como parâmetro e retorne o número de
caracteres na string.*/

using System;

namespace A20
{
 class Program
 {
  static int metodo (string var1)
  {
   return var1.Length;
  }
  
  
  
  public static void Main(string[] args)
  {
   string var2;
   
   Console.WriteLine("Digite uma palavra");
   var2 = Console.ReadLine();
   
   Console.WriteLine(metodo(var2));
   
   
   Console.Write("Press any key to continue . . . ");
   Console.ReadKey(true);
  }
 }
}
