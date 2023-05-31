/*Crie um programa que peça ao usuário para digitar uma palavra e verifique
se ela não é vazia. Se a condição for verdadeira, o programa deve imprimir
&quot;A palavra não é vazia&quot;.
*/
using System;

class Program {
  public static void Main (string[] args) {
    // Variáveis
    string palavra;
    //Entrada de dados
    Console.Write("Por favor, digite uma palavra: ");
    palavra = Console.ReadLine();
    // Saída
    if (string.IsNullOrEmpty(palavra)) {
   Console.Write("A palavra {0} é vazia", palavra);
      }
      else {
      Console.Write("A palavra {0} não é vazia", palavra);
      }
  }
}