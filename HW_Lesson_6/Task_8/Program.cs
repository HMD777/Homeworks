Console.WriteLine("В прямоугольной матрице найти строку с наименьшей суммой элементов.");
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

void arrayMinSum (int [,] array)
{
    int sum = 0;
    int min = 0;
    int index = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        min = min + array [0, i];
    }

    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array [i, j];
        }
        if (sum < min)
        {
            min = sum;
            index = i;
        }
    }
    Console.WriteLine($"Cтрока '{index+1}' является наименьшей суммой элементов, которая равен: {min}!");
}

if (rows > 0 && columns > 0)
{
    Console.WriteLine("Введите минимальное число в массиве: ");
    int min = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите максимальное число в массиве: ");
    int max = int.Parse(Console.ReadLine());
    int [,] matrix = new int[rows, columns];
    fillArray(matrix, min, max);
    printArray(matrix);
    Console.WriteLine();
    arrayMinSum(matrix);
}
else if (rows < 0 | columns < 0)
{
    Console.WriteLine("Ощибка! Количество строк или столбцов не могут быть отрицательными!");
}
else
{
    Console.WriteLine("Ощибка! Количество строк или столбцов должны быть одинаковыми!");
}