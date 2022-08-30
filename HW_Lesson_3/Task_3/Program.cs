Console.WriteLine("Подсчитать сумму цифр в числе");
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int countDigit (int a)
{
    int i = 0;
    int digit = a;
    int result = 0;
    while (digit > 0)
    {
        result = result + digit % 10;
        digit = (digit/10);
        i++;
    }
    return result;
}

int result = countDigit(num);
Console.WriteLine($"Количество цифр в числе: {result}");