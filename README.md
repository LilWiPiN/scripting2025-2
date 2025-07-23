# scripting2025-2

Entrega de taller 1 de repaso Scripting.

* Rey Valentín Arias Pérez

## 1. Preguntas autoasignadas

### FUNCIONES

* Realizar una función que calcule si una cadena es palindroma. 

```c#
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa una cadena: ");
        string input = Console.ReadLine();

        if (EsPalindroma(input))
            Console.WriteLine("La cadena es palíndroma.");
        else
            Console.WriteLine("La cadena no es palíndroma.");
    }

    static bool EsPalindroma(string texto)
    {
        string limpio = Regex.Replace(texto.ToLower(), "[^a-z0-9]", "");

        char[] caracteres = limpio.ToCharArray();
        Array.Reverse(caracteres);
        string invertido = new string(caracteres);

        return limpio == invertido;
    }
}

```

* Realice la implementación de las firmas de las siguientes invocaciones.

```c#
using System;

public class ImplementarFirmas
{
    public static void Main(string[] args)
    {
        // Invocaciones de ejemplo
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
        // Intentar convertir la cadena en un número decimal
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
```

### ARREGLOS-MATRICES

* Dada una matriz nxm de caracteres, elimine las vocales de la matriz y reemplacelas con una x.

```c#
using System;

class Program
{
    static void Main()
    {
        // Ejemplo de matriz 3x4
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
        {
            for (int j = 0; j < columnas; j++)
            {
                if (vocales.Contains(matriz[i, j]))
                {
                    matriz[i, j] = 'x';
                }
            }
        }
    }

    static void ImprimirMatriz(char[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

```

### CADENAS

* Lea una cadena de números enteros positivos y luego cree un array con los números de la cadena, se debe validar que la cadena contenga números.

```c#
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

```

### CICLOS

* Calcule el mayor y el menor número de un array de números long.

```c#
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
```

### TEORIA

* ¿Qué es una variable tipo acumulador? Escriba un ejemplo.

Variable que se utiliza para sumar o acumular valores progresivamente durante la ejecución de un programa. Su valor se va modificando en un bucle (por ejemplo, sumando, restando, multiplicando, etc.).

* i
* sum
* index
* contador

```c#
using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 3, 7, 2, 9, 4 };
        int suma = 0;

        foreach (int num in numeros)
        {
            suma += num;
        }

        Console.WriteLine("La suma total es: " + suma);
    }
}

```

* ¿Qué es una variable bandera? Escriba un ejemplo.

Variable booleana o similar que se utiliza para indicar si una condición se ha cumplido o no durante la ejecución de un programa.

```c#
bool aprobado = false;

int nota = 75;

if (nota >= 60)
    aprobado = true;

Console.WriteLine(aprobado ? "Aprobado" : "Reprobado");

```

## 2. Actividad interactiva

### Ahorcado

<img width="1618" height="503" alt="Screenshot 2025-07-23 072349" src="https://github.com/user-attachments/assets/7c43120f-4122-4918-85e6-9ec479479c4a" />

## 3. Command Challenge

🐌🦋🐛🐜🕸️🐳🐋🐬🐟🐠🐡🐺🐝🐞🦗🕷️🦀🦟🪱🦠🐵🐶
🦊🐱🦁🐯🐴🦄🐮🐷🐭🐹🐻🐼🐣🦚🐸🐲🌺🌹🌷🌻

![alt text](image.png)

## 4. 20 Firmas

```c#
public void DoSomething() {}

private int CalculateSum(int a, int b) {}

protected static string GetName() {}

internal virtual bool IsValid(string input) {}

protected internal override void OnStart() {}

private protected async Task<int> FetchDataAsync(string url) {}

public static List<string> GetList(int count) {}

private extern void ExternalMethod();

public async Task SaveAsync(string path, byte[] data) {}

protected abstract void Initialize();

internal string FormatMessage(string msg, int repeat = 1) {}

private protected static bool TryParse(string input, out int result) {}

public void LogMessage(ref string message) {}

protected internal int AddNumbers(params int[] numbers) {}

internal abstract Task ProcessAsync(CancellationToken token);

public static T GetDefault<T>() {}

internal protected virtual List<int> GenerateSequence(int start, int count) {}

public sealed override string ToString() => base.ToString();

private protected void ConfigureSettings(Dictionary<string, string> settings) {}

public async Task<bool> ValidateAsync(string input, int minLength, CancellationToken token) {}

```

