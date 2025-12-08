using System;

public class ColaArreglo
{
    private const int MAX_SIZE = 5;
    private int[] queue;
    private int front, rear;

    public ColaArreglo()
    {
        queue = new int[MAX_SIZE];
        front = -1;
        rear = -1;
    }

    public bool IsFull()
    {
        return (front == 0 && rear == MAX_SIZE - 1) || (front == rear + 1);
    }

    public bool IsEmpty()
    {
        return front == -1;
    }

    public void Enqueue(int elemento)
    {
        if (IsFull())
        {
            Console.WriteLine("Error: Cola desbordada (Overflow)");
            return;
        }
        
        if (front == -1) front = 0;
        rear = (rear + 1) % MAX_SIZE;
        queue[rear] = elemento;
    }

    public int Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Error: Cola subdesbordada (Underflow)");
            return -1;
        }
        
        int elemento = queue[front];
        if (front == rear)
        {
            front = -1;
            rear = -1;
        }
        else
        {
            front = (front + 1) % MAX_SIZE;
        }
        return elemento;
    }

    public int Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Cola vacía");
            return -1;
        }
        return queue[front];
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        ColaArreglo cola = new ColaArreglo();
        cola.Enqueue(10);
        cola.Enqueue(20);
        cola.Enqueue(30);
        
        Console.WriteLine("Elemento frontal: " + cola.Peek());
        Console.WriteLine("Elimina elemento: " + cola.Dequeue());
        Console.WriteLine("Nuevo elemento frontal: " + cola.Peek());

        cola.Enqueue(40);
        cola.Enqueue(50);
        cola.Enqueue(60);
        Console.WriteLine("Elimina elemento: " + cola.Dequeue());
    }
}