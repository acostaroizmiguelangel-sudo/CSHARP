
using System;
using System.Collections.Generic;

public class quickSort
{
    private static void Swap(List<int> arr, int j, int k)
    {
        int temp = arr[j];
        arr[j] = arr[k];
        arr[k] = temp;
    }

    private static int Partition(List<int> arr, int low, int high)
    {
        int pivot = arr[high];
        int j = low - 1;

        for (int k = low; k < high; k++)
        {
            if (arr[k] <= pivot)
            {
                j++;
                Swap(arr, j, k);
            }
        }
        Swap(arr, j + 1, high);
        return j + 1;
    }

    private static void recursivo(List<int> arr, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(arr, low, high);
            recursivo(arr, low, pi - 1);
            recursivo(arr, pi + 1, high);
        }
    }

    public static void Main(string[] args)
    {
        Random random = new Random();
        List<int> numeros = new List<int>();

        for (int i = 0; i < 20; i++)
        {
            numeros.Add(random.Next(1, 101));
        }

        Console.WriteLine("El arreglo antes de ordenarlo:");
        foreach (int num in numeros)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        QuickSortRecursive(numeros, 0, numeros.Count - 1);

        Console.WriteLine("\nEl arreglo después de ordenarlo:");
        foreach (int num in numeros)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}