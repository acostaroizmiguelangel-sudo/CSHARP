using System;

class Program
{
    static void Inserccion(int[] a)
    {
        for (int i = 1; i < a.Length; i++)
        {
            int temp = a[i];
            int j = i - 1;
            while (j >= 0 && temp < a[j])
            {
                a[j + 1] = a[j];
                j--;
            }
            a[j + 1] = temp;
        }
    }

    static void PrintArr(int[] a)
    {
        foreach (int value in a)
        {
            Console.Write(value + " ");
        }
    }

    static void Main()
    {
        int[] a = {70, 15, 2, 51, 60};
        Console.WriteLine("Esta es la lista antes de ordenarla:");
        PrintArr(a);
        Inserccion(a);
        Console.WriteLine("\nLa lista despues de ordenarla:");
        PrintArr(a);
    }
}
