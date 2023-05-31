/*Escreva um programa que pergunte ao usuário se ele não é um membro
inativo de um clube. Se a resposta for negativa, o programa deve imprimir
&quot;Por favor, atualize sua inscrição para continuar usufruindo dos benefícios
do clube&quot;.
*/

using System;

class Program {
  public static void Main (string[] args) {
    //Variáveis
    string resposta;
    //Entrada de dados
    Console.Write("Você é um membro ativo de um clube? ");
    resposta = Console.ReadLine();
    // Saída de dados
    if (resposta == "Não" || resposta == "não" || resposta == "nao")
     {
       Console.WriteLine("Por favor, atualize sua inscrição para continuar usufruindo dos benefícios do clube.");
     }
  }
}