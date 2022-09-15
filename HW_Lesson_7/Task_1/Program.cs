Console.WriteLine("Найти произведение двух матриц.");
Console.WriteLine("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine());

void FillArray(int[,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
}

void PrintArray(int[,] array)
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

void ArrayProduct(int[,] array1, int[,] array2, int[,] array3)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            array3[i, j] = array1[i, j] * array2[i, j];
        }
    }
}

if (rows > 0 && columns > 0)
{
    Console.WriteLine("Введите минимальное число в массиве: ");
    int min = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите максимальное число в массиве: ");
    int max = int.Parse(Console.ReadLine());
    int[,] matrix1 = new int[rows, columns];
    int[,] matrix2 = new int[rows, columns];
    int[,] matrix3 = new int[rows, columns];
    FillArray(matrix1, min, max);
    FillArray(matrix2, min, max);
    ArrayProduct(matrix1, matrix2, matrix3);
    PrintArray(matrix1);
    Console.WriteLine();
    PrintArray(matrix2);
    Console.WriteLine();
    PrintArray(matrix3);
}
else
{
    Console.WriteLine("Ощибка! Количество строк или столбцов не могут быть отрицательными!");
}
