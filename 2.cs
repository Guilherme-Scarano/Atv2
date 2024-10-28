using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma palavra: ");
        string palavra = Console.ReadLine();

        Console.Write("Digite uma letra: ");
        char letra = Console.ReadLine()[0];

        palavra = palavra.ToUpper();
        letra = Char.ToUpper(letra);

        int contador = 0;
        foreach (char c in palavra)
        {
            if (c == letra)
            {
                contador++;
            }
        }

        Console.WriteLine("A letra '" + letra + "' aparece " + contador + " vez(es) na palavra.");
    }
}