Console.WriteLine("Найти максимальное из трех чисел.");
Console.WriteLine("Введите первое число:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int num3 = int.Parse(Console.ReadLine());
int max = num1;
if (num2 > max)
{
    max = num2;
}
else
{
    if (num3 > max)
    {
        max = num3;
    }
}
Console.WriteLine("Максимально число это: " + max);