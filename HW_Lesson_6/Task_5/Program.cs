Console.WriteLine("Написать программу, которая обменивает элементы первой строки и последней строки.");
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

void arrayChange (int [,] arrayOld, int [,] arrayNew)
{
    for (int i = 0; i < arrayOld.GetLength(0); i++)
    {
        for (int j = 0; j < arrayOld.GetLength(1); j++)
        {
            if (i == 0 | i == (arrayOld.GetLength(0)-1))
            {
                arrayNew[arrayNew.GetLength(0)-(i+1), j] = arrayOld[i, j];
            }
            else
            {
                arrayNew[i, j] = arrayOld[i, j];
            }
        }
    }
}

if (rows > 0 && columns > 0)
{
    int [,] matrix = new int[rows, columns];
    int [,] matrix2 = new int[rows, columns];
    fillArray(matrix, min, max);
    printArray(matrix);
    Console.WriteLine();
    arrayChange(matrix, matrix2);
    printArray(matrix2);
}
else
{
    Console.WriteLine("Ощибка! Количество строк или столбцов не могут быть отрицательными!");
}