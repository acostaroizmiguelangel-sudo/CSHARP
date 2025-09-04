using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> arr = new List<int> {1,2,3,4,5,6,7,8,9};

        Console.WriteLine("Valores que están en el arreglo:");
        for (int i = 0; i < arr.Count; i++)
        {
            Console.WriteLine($"Índice {i} : {arr[i]}");
        }

        Console.Write("¿Qué número quieres ingresar? ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("¿En qué posición quieres que lo ponga? ");
        int posi = int.Parse(Console.ReadLine());

        arr.Insert(posi, n);

        Console.WriteLine("\nYa actualizado:");
        for (int i = 0; i < arr.Count; i++)
        {
            Console.WriteLine($"Índice {i} : {arr[i]}");
        }
    }
}
