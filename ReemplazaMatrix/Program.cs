using System;

class Program
{
    static void Main()
    {
        char[,] matriz = {
            { 'H', 'o', 'l', 'a' },
            { 'M', 'u', 'n', 'd' },
            { 'o', '!', 'A', 'm' }
        };

        Console.WriteLine("Matriz original:");
        ImprimirMatriz(matriz);

        ReemplazarVocales(ref matriz);

        Console.WriteLine("\nMatriz modificada:");
        ImprimirMatriz(matriz);
    }

    static void ReemplazarVocales(ref char[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        string vocales = "aeiouAEIOU";

        for (int i = 0; i < filas; i++)
            for (int j = 0; j < columnas; j++)
                if (vocales.Contains(matriz[i, j]))
                    matriz[i, j] = 'x';
        }
    }

    static void ImprimirMatriz(char[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
                Console.Write(matriz[i, j] + " ");
                
            Console.WriteLine();
        }
    }
}
