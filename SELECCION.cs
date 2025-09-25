using System;

class Program {
    static void Main() {
        int[] arr = {64, 25, 12, 22, 11};

        for (int i = 0; i < arr.Length - 1; i++) {
            int min_idx = i;
            for (int j = i + 1; j < arr.Length; j++) {
                if (arr[j] < arr[min_idx]) {
                    min_idx = j;
                }
            }

            int temp = arr[min_idx];
            arr[min_idx] = arr[i];
            arr[i] = temp;
        }

        Console.WriteLine("Ya arreglado: " + string.Join(", ", arr));
    }
}
