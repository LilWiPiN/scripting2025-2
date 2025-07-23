using System;

class Program
{
    static void Main()
    {
        // Array de ejemplo
        long[] numeros = { 1500, 9876543210, 3, 789, 1234567890123, 42 };

        // Obtener mayor y menor
        long mayor = EncontrarMayor(numeros);
        long menor = EncontrarMenor(numeros);

        Console.WriteLine("Mayor número: " + mayor);
        Console.WriteLine("Menor número: " + menor);
    }

    static long EncontrarMayor(long[] array)
    {
        long max = array[0];
        foreach (long num in array)
        {
            if (num > max)
                max = num;
        }
        return max;
    }

    static long EncontrarMenor(long[] array)
    {
        long min = array[0];
        foreach (long num in array)
        {
            if (num < min)
                min = num;
        }
        return min;
    }
}
