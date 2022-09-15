Console.WriteLine("В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.");
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

int ArrayMin(int[,] array, int arg)
{
    int min = array[0, 0];
    int row = 0;
    int column = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                row = i;
                column = j;
            }
        }
    }

    if (arg == 0)
    {
        return row;
    }
    return column;
}

void ArrayModify(int[,] arrayOld, int[,] arrayNew, int row, int column)
{
    for (int i = 0; i < arrayOld.GetLength(0); i++)
    {
        for (int j = 0; j < arrayOld.GetLength(1); j++)
        {
            if (i != row && j != column)
            {
                arrayNew[i, j] = arrayOld[i, j];
            }
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
    FillArray(matrix1, min, max);
    int row = ArrayMin(matrix1, 0);
    int column = ArrayMin(matrix1, 1);
    ArrayModify(matrix1, matrix2, row, column);
    PrintArray(matrix1);
    Console.WriteLine();
    PrintArray(matrix2);
}
else
{
    Console.WriteLine("Ощибка! Количество строк или столбцов не могут быть отрицательными!");
}
