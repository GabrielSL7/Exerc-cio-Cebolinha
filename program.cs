using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine()!;

        string fraseCebolinha = frase.Replace("r", "l").Replace("R", "L");

        Console.WriteLine("Cebolinha diria:");
        Console.WriteLine(fraseCebolinha);
    }
}
