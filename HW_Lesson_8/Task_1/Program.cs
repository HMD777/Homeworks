Console.WriteLine("Показать натуральные числа от M до N, N и M заданы.");
Console.WriteLine("Введите стартовое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите конечное число: ");
int num2 = int.Parse(Console.ReadLine());

void ShowNumbers(int start, int end)
{
    if (start > end)
    {
        for (int i = start; i >= end; i--)
        {
            Console.Write($"{i}, ");
        }
    }
    else if (start < end)
    {
        for (int i = start; i <= end; i++)
        {
            Console.Write($"{i}, ");
        }
    }
    else Console.WriteLine(start);
}

ShowNumbers(num1, num2);