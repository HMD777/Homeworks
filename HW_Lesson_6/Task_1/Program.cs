Console.WriteLine("Показать двумерный массив размером m×n заполненный вещественными числами");
Console.WriteLine("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное число в массиве: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное число в массиве: ");
int max = int.Parse(Console.ReadLine());

void fillArray (int [,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i, j] = new Random().Next(min, max);
        }
    }
}

void printArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    
}

int [,] matrix = new int[rows, columns];
fillArray(matrix, min, max);
printArray(matrix);