Console.WriteLine("Написать программу вычисления функции Аккермана.");
Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

int AkkermanFunction(int i, int j)
{
    if (i == 0)
        return j + 1;
    else
      if ((i != 0) && (j == 0))
        return AkkermanFunction(i - 1, 1);
    else
        return AkkermanFunction(i - 1,AkkermanFunction(i, j - 1));
}

if (num1 >= 0 && num2 >= 0)
{
    int result = AkkermanFunction(num1, num2);
    Console.WriteLine($"Результат вычисления функции Аккермана ввденными данными ({num1}, {num2}') является '{result}'.");
}
else Console.WriteLine("Вычисления функции Аккермана не допустимо с отрицательными числами");