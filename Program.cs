using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creamos una instancia de Queue<string> llamada miCola para almacenar cadenas.
        Queue<string> miCola = new Queue<string>();

        // Agregamos elementos a la cola usando el método Enqueue.
        miCola.Enqueue("Elemento 1");
        miCola.Enqueue("Elemento 2");
        miCola.Enqueue("Elemento 3");

        // Mostramos los elementos en la cola usando un bucle foreach.
        Console.WriteLine("Elementos en la cola:");
        foreach (string elemento in miCola)
        {
            Console.WriteLine(elemento);
        }

        // Eliminamos un elemento de la cola usando el método Dequeue.
        string elementoEliminado = miCola.Dequeue();

        // Mostramos el elemento eliminado.
        Console.WriteLine("\nElemento eliminado de la cola: " + elementoEliminado);

        // Mostramos los elementos restantes en la cola después de la eliminación.
        Console.WriteLine("\nElementos en la cola después de la eliminación:");
        foreach (string elemento in miCola)
        {
            Console.WriteLine(elemento);
            Console.ReadLine();
        }
    }
}
