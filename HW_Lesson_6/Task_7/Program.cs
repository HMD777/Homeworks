Console.WriteLine("Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).");
Console.WriteLine("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine());


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

void arrayChange (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            int temp = array [i, j];
            array [i, j] = array [j, i];
            array [j, i] = temp;       
        }
    }
}

if (rows > 0 && columns > 0 && rows == columns)
{
    Console.WriteLine("Введите минимальное число в массиве: ");
    int min = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите максимальное число в массиве: ");
    int max = int.Parse(Console.ReadLine());
    int [,] matrix = new int[rows, columns];
    fillArray(matrix, min, max);
    printArray(matrix);
    Console.WriteLine();
    arrayChange(matrix);
    printArray(matrix);
}
else if (rows < 0 | columns < 0)
{
    Console.WriteLine("Ощибка! Количество строк или столбцов не могут быть отрицательными!");
}
else
{
    Console.WriteLine("Ощибка! Количество строк или столбцов должны быть одинаковыми!");
}