/*Escreva um programa que pergunte ao usuário se ele não deseja cancelar
uma operação. Se a resposta for negativa, o programa deve imprimir &quot;Por
favor, confirme o cancelamento da operação&quot;. */

using System;

class Program {
  public static void Main (string[] args) {
    // Variaveis
    string resposta;
   // Entrada de dados
    Console.Write("Você deseja não cancelar a operação? ");
    resposta = Console.ReadLine();
    // Saída de dados
    if (resposta == "Não" || resposta == "nao")
    Console.Write("Por favor, confirme o cancelamento da operação");
  }
}