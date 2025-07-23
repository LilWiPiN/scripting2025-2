using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa una cadena: ");
        string input = Console.ReadLine();

        if (EsPalindroma(input))
        {
            Console.WriteLine("La cadena es palíndroma.");
        }
        else
        {
            Console.WriteLine("La cadena no es palíndroma.");
        }
    }

    static bool EsPalindroma(string texto)
    {
        // Eliminar espacios, signos de puntuación y convertir a minúsculas
        string limpio = Regex.Replace(texto.ToLower(), "[^a-z0-9]", "");

        // Comparar con la cadena invertida
        char[] caracteres = limpio.ToCharArray();
        Array.Reverse(caracteres);
        string invertido = new string(caracteres);

        return limpio == invertido;
    }
}
