Console.WriteLine("Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента");
Console.WriteLine("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество страниц в массиве: ");
int pages = int.Parse(Console.ReadLine());

void FillArray(int[,,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(min, max);
                for (int l = i; l >0; l--)
                {
                    for (int m = j; m >0; m--)
                    {
                        for (int n = k-1; n > 0; n--)
                        {
                            int num = array [i,j,k];
                            if (i == l && j == m && k == m) break;
                            while (num == array[l, m, n])
                            {
                                num = new Random().Next(min, max);
                            }
                            array [i,j,k] = num;
                        }
                    }
                }
            }
        }
    }

}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"Индекс массива ({i},{j},{k}) = {array[i, j, k]}");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

}


if (rows > 0 && columns > 0 && pages > 0)
{
    int min = 10;
    int max = 100;
    int[,,] matrix = new int[rows, columns, pages];
    FillArray(matrix, min, max);
    PrintArray(matrix);
}
else
{
    Console.WriteLine("Ощибка! Количество строк, столбцов или страниц не могут быть отрицательными!");
}
