using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa una cadena de números enteros positivos separados por espacios: ");
        string input = Console.ReadLine();

        // Intentar convertir la cadena a un array de enteros
        int[] numeros = ObtenerArrayDesdeCadena(input);

        if (numeros != null)
        {
            Console.WriteLine("Array generado:");
            foreach (int num in numeros)
            {
                Console.Write(num + " ");
            }
        }
        else
        {
            Console.WriteLine("La cadena contiene elementos que no son números enteros positivos.");
        }
    }

    static int[] ObtenerArrayDesdeCadena(string cadena)
    {
        string[] partes = cadena.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int[] numeros = new int[partes.Length];

        for (int i = 0; i < partes.Length; i++)
        {
            bool esNumero = int.TryParse(partes[i], out int valor);
            if (!esNumero || valor <= 0)
            {
                return null; // error si no es un número o si no es positivo
            }
            numeros[i] = valor;
        }

        return numeros;
    }
}
