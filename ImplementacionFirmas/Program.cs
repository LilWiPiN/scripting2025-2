using System;

public class ImplementarFirmas
{
    public static void Main(string[] args)
    {
        string concatenacion = Concatenar("Hola", " ", "mundo");
        Console.WriteLine(concatenacion);

        double fraccionar = Fraccionar("123.34");
        Console.WriteLine(fraccionar);

        int contador = Contar(1, 3.4, "hola", '3');
        Console.WriteLine(contador);
    }

    public static string Concatenar(string word1, string word2, string word3)
    {
        return word1 + word2 + word3;
    }

    public static double Fraccionar(string numero)
    {
        if (double.TryParse(numero, out double valor))
            return valor;
        else
            throw new FormatException("No es un número decimal válido.");
    }

    public static int Contar(params object[] elementos)
    {
        return elementos.Length;
    }
}