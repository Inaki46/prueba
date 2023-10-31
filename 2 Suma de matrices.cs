using System;

class actividad
{
    static void Main()
    {
        int[,] matriz1 = new int[[1, 2, 3, 4], [5, 6, 7, 8], [9, 10, 11, 12], [13, 14, 15, 16]];
        int[,] matriz2 = new int[[17, 18, 19, 20], [21, 22, 23, 24], [25, 26, 27, 28], [29, 30, 31, 32]];
        Console.WriteLine(SumMatrix(matriz1, matriz2));
        Console.WriteLine(FiltrandoValores());
    }
    static List SumMatrix(List lista1, List lista2)
    {
        for (int x = 0; x < lista1.Count; x++)
        {
            for (int y = 0; y < lista1.Count; y++)
            {
                lista[x][y] = lista[x][y] + lista2[x][y];
            }
        }
    }
}