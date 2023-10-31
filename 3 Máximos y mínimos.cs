using System;

class Actividad
{
    static void Main()
    {
        Console.WriteLine("elnumerode consonantes es: ");
        Console.WriteLine(FiltrandoValores());
    }
    static int FiltrandoValores()
    {
        Queue<int> cola = new Queue<int>();
        int n = 0;
        int minimo = 1000000;
        int maximo = 0;
        string entrada = "";
        Console.WriteLine("escribe la cantidad de numeros:");
        n = Console.ReadLine();
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("escribe un numero:");
            entrada = Console.ReadLine();
            cola.Enqueue(entrada);
            if (entrada < minimo)
            {
                minimo = entrada;
            }
            if (entrada > maximo)
            {
                maximo = entrada;
            }
        }

    }
}
