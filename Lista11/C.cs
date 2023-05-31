/*Crie um método que receba dois números inteiros como parâmetros e retorne a
soma deles.*/
using System;

namespace A30
{
 class Program
 {
  static int metodo (int var1,int var2)
  {
   return var1 + var2;
  }
  
  public static void Main(string[] args)
  {
   int p1,p2;

   Console.WriteLine("Digite um numero");
   p1 = int.Parse(Console.ReadLine());
   
   Console.WriteLine("Digite um numero");
   p2 = int.Parse(Console.ReadLine());
   
   
   
   Console.WriteLine(metodo(p1,p2));
   
   
   Console.Write("Press any key to continue . . . ");
   Console.ReadKey(true);
  }
 }
}
