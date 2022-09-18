// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задайте значения M и N. "
+ "Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N");
Console.WriteLine("Введите стартовое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите конечное число: ");
int num2 = int.Parse(Console.ReadLine());

int SumNumbers(int start, int end)
{
    int result = start;
    if (end > start)
    {
        result = result + SumNumbers(start + 1, end);
    }
    return result;
}

if (num1 > num2)
{
    Console.WriteLine($"Сумма элекментов от '{num1}' до '{num2}' равен '{SumNumbers(num1, num2)}'");
}
else if (num1 < num2)
{
    Console.WriteLine($"Сумма элекментов от '{num1}' до '{num2}' равен '{SumNumbers(num2, num1)}'");
}
else Console.WriteLine($"Сумма элекментов от '{num1}' до '{num2}' равен '{num1}'");