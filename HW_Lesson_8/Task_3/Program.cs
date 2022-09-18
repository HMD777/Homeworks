using System;
Console.WriteLine("Найти сумму цифр числа.");
Console.WriteLine("Введите число: ");
string num = Console.ReadLine();

void NumSum(string array)
{
    int check = int.Parse(array);
    int start = 1;
    string negative = "-";
    if (check > 0) 
    {
        start = 0;
        negative = "";
    }
    int result = 0;
    for (int i = start; i < array.Length; i++)
    {
        result += (int)Char.GetNumericValue(array[i]);
    }
    Console.WriteLine($"Сумма цифр числа '{array}' равен '{negative}{result}'");

}

NumSum(num);