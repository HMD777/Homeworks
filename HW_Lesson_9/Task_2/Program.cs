// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задайте значения M и N. "
+ "Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N");
Console.WriteLine("Введите стартовое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите конечное число: ");
int num2 = int.Parse(Console.ReadLine());

void SumNumbers(int start, int end)
{
    int result = 0;
    if (start > end)
    {
        for (int i = end; i <= start; i++)
        {
            result = result + i;
        }
    }
    else if (start < end)
    {
        for (int i = start; i <= end; i++)
        {
            result = result + i;
        }
    }
    else result = start;
    Console.WriteLine($"Сумма элекментов от '{start}' до '{end}' равен '{result}'.");
}

SumNumbers(num1, num2);