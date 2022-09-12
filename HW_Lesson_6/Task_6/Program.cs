Console.WriteLine("Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.");
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

void arrayFilterMax (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            
            for (int n = j; n < array.GetLength(1); n++)
            {
                int max = array [i, j];
                if (array [i, n] > max)
                {
                    max = array[i, n];
                    array [i, n] = array[i, j];
                    array [i, j] = max;
                }
            }
        }
    }
}

if (rows > 0 | columns > 0)
{
    int [,] matrix = new int[rows, columns];
    fillArray(matrix, min, max);
    printArray(matrix);
    Console.WriteLine();
    arrayFilterMax(matrix);
    printArray(matrix);
}
else
{
    Console.WriteLine("Ощибка! Количество строк или столбцов не могут быть отрицательными!");
}