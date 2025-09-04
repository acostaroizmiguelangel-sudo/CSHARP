using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> datos = new List<int> { 1, 2, 3, 4 };

        Console.WriteLine(datos[1]);  
        datos.Add(5);                
        Console.WriteLine(datos[4]); 
    }
}
