int calc (int a, int b)
{
    int i = 0;
    int result = 1;
    while (i <b)
    {
        result *= a;
        i++;
    }
    return result;
}

Console.WriteLine("Возведите число А в натуральную степень B используя цикл");
Console.WriteLine("Введите число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int num2 = int.Parse(Console.ReadLine());

int result = calc(num1, num2);
Console.WriteLine($"Число '{num1}' в степени '{num2}' будет равен '{result}'!");