using System;

class actividad
{
    static void Main()
    {
        Console.WriteLine("el numero de consonantes es: ");
        Console.WriteLine(FiltrandoValores());
    }
    static int FiltrandoValores()
    {
        Stack<string> myStack = new Stack<string>();
        int n = 0;
        int cant = 0;
        Console.WriteLine("escribe la cantidad de cadenas:");
        n = Console.ReadLine();
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("escribe la cadena:");
            if (int.TryParse(Console.ReadLine(), out _))
            {
                myStack.Push(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("no ingresaste una cadena intentalo de nuevo:");
            }
            if (int.TryParse(Console.ReadLine(), out _))
            {
                myStack.Push(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("no ingresaste una cadena intentalo de nuevo:");
            }
        }
        while (miPila.Count > 0)
        {
            foreach (char i in miPila.Pop())
            {


                if (i == 'a' || i == 'b' || i == 'c' || i == 'd' || i == 'f' || i == 'g' || i == 'h' || i == 'j' || i == 'k' || i == 'l' || i == 'm' || i == 'n' || i == 'p' || i == 'q' || i == 'r' || i == 's' || i == 't' || i == 'v' || i == 'w' || i == 'x' || i == 'y' || i == 'z')
                {
                    cant = cant + 1;
                }
            }
        }
        return cant;
    }
}