// See https://aka.ms/new-console-template for more information
Console.WriteLine("Написать программу показывающие первые N чисел, для которых"
+ "каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности"
+ "задаются пользователем");
Console.WriteLine("Введите длинну вычисления последовательности: ");
int count = int.Parse(Console.ReadLine());

void FibonaciUserDefined(int count, int num1, int num2)
{
    int temp1 = num1;
    int temp2 = num2;
    Console.Write($"{num1}, {num2}");
    for (int i = 0; i < count; i++)
    {
        int result = temp1 + temp2;
        Console.Write($", {result}");
        temp1 = temp2;
        temp2 = result;
    }
}

if (count>0)
{
Console.WriteLine("Введите первое число для вычисления последовательности: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число для вычисления последовательности: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine($"Результат выичсления: ");
FibonaciUserDefined(count, num1, num2);
}
else Console.WriteLine("Длинна вычисления последовательности не может быть отрицательной!");