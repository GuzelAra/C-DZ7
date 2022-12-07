// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2

// 5 9 2 3

// 8 4 2 4
// 17 -> такого числа в массиве нет


Console.WriteLine("Введите размернось двухмерного массива m *n");
Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(0, 11);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine("");
}
Console.WriteLine("Введите x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x >= m || y >= n)
{ Console.WriteLine("Такого элемента не существует"); }
else
{
    Console.WriteLine($"Значение элемента с такой позицией {matrix[x, y]}");
}

