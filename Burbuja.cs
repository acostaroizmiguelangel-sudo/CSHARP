using System;

class Program
{
    static void Burbuja(int[] lista)
    {
        int n = lista.Length;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (lista[j] > lista[j + 1])
                {
                    int temp = lista[j];
                    lista[j] = lista[j + 1];
                    lista[j + 1] = temp;
                }
            }
        }
    }

    static void Main()
    {
        int[] datos = new int[5];

        Console.WriteLine("Hola, ingrese 5 números y serán ordenados:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Ingrese el número {i + 1}: ");
            datos[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nEstos son los datos antes de ordenar:");
        foreach (int num in datos)
        {
            Console.Write(num + " ");
        }

        Burbuja(datos);

        Console.WriteLine("\nEstos son los datos después de ordenar:");
        foreach (int num in datos)
        {
            Console.Write(num + " ");
        }
    }
}
