using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o primeiro texto: ");
        string texto1 = Console.ReadLine();

        Console.Write("Digite o segundo texto: ");
        string texto2 = Console.ReadLine();

        bool saoIguais = string.Compare(texto1.ToUpper(), texto2.ToUpper()) == 0;

        if (saoIguais)
        {
            Console.WriteLine("Os textos são iguais (ignorando maiúsculas e minúsculas).");
        }
        else
        {
            Console.WriteLine("Os textos são diferentes.");
        }

        Console.WriteLine("Quantidade de caracteres do primeiro texto: " + texto1.Length);
        Console.WriteLine("Quantidade de caracteres do segundo texto: " + texto2.Length);
    }
}