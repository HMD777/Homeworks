Console.WriteLine("По двум заданным числам проверять является ли одно квадратом другого");
Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
int max = num1;
int min = num2;
if (num2>num1) 
{
    max = num2;
    min = num1;
}
if (Math.Pow(min, 2) == max)
    {
        Console.WriteLine($"Число '{max}' являестя квадратом числа '{min}'!");
    }
else
    {
        Console.WriteLine($"Число '{max}' не являестя квадратом числа '{min}'!");
    }
