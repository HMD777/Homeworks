Console.WriteLine("Написать программу вычисления произведения чисел от 1 до N");
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int sumfunc (int a)
{
    int result = a;
    for (int i = 1; i < a; i++)
    {
        result *= i;
    }
    return result;
}
int result = sumfunc(num);
Console.WriteLine($"Произведение чисел от 1 до '{num}' равен '{result}'!");