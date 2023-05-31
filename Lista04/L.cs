/*Crie um programa que peça ao usuário para digitar um número e verifique se
ele não é igual a zero. Se a condição for verdadeira, o programa deve
imprimir &quot;O número é diferente de zero&quot;.
*/
using System;

class Program {
  public static void Main (string[] args) {
    // Variáveis
    double n1;
    //Entrada de dados
    Console.Write("Por favor, digite um número: ");
    n1 = Convert.ToDouble(Console.ReadLine());
    // Saída de dados
    if (n1 != 0) {
      Console.WriteLine("O número {0} é diferente de 0.", n1);
    }
  }
}