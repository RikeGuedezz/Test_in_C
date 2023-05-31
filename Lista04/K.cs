/*Escreva um programa que pergunte ao usuário se ele não é um robô. Se a
resposta for negativa, o programa deve imprimir &quot;Por favor, prove que você
não é um robô&quot;..*/



using System;

class Program {
  public static void Main (string[] args) {
    string resposta;
    Console.WriteLine ("Você é um robô?");
    resposta = Console.ReadLine().ToUpper();
    if (resposta == "SIM" || resposta == "S" || resposta == "sim")
    Console.WriteLine("Por favor, prove que você não é um robô.");
  }
}