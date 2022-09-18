Console.WriteLine("Задайте значения M и N." +
" Напишите программу, которая выведет все натуральные числа в промежутке от M до N");
Console.WriteLine("Введите стартовое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите конечное число: ");
int num2 = int.Parse(Console.ReadLine());

void ShowPlus(int start, int end)
{
    if (end >= start)
    {
        Console.Write("{0} ", start);
        ShowPlus(start + 1, end);
    }
}

void ShowMinus(int start, int end)
{
    if (end <= start)
    {
        Console.Write("{0} ", start);
        ShowMinus(start - 1, end);
    }
}
if (num1 < num2)
{
    ShowPlus(num1, num2);
}
else ShowMinus(num1, num2);