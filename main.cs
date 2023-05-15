using System;

public class Program
{
    public static void Main(string[] args)
    {

// Criptografia MIMIMI:
// Implemente um programa que descreva a pseudo-criptografia do MIMI a partir de uma mensagem enviada
// Resposta: To com sono para estudar  - Ti cim sini piri istídir.


Console.WriteLine("Digite uma frase"); 

string x = Console.ReadLine();

string z = x.Replace("A", "i").Replace("E", "i").Replace("I", "i").Replace("O", "i").Replace("U", "i").Replace("a", "i").Replace("e", "i").Replace("i", "i").Replace("o", "i").Replace("u", "i").Replace("Á", "i").Replace("É", "i").Replace("Í", "i").Replace("Ó", "i").Replace("Ú", "i").Replace("á", "i").Replace("é", "i").Replace("í", "i").Replace("ó", "i").Replace("ú", "i");

Console.WriteLine(z);





      



    }
}