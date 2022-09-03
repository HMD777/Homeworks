Console.WriteLine("Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");

Console.WriteLine("Введите длинну массива: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное число массива: ");
int minNum = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное число массива: ");
int maxNum = int.Parse(Console.ReadLine());

int [] array = new int [num];

int [] arrayGen (int [] array, int min, int max)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = random.Next(min, max);
    }
    return array;
}

int arrayMin (int [] array)
{
    int min = array [0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] < min) min = array [i];
    }
    return min;
}

int arrayMax (int [] array)
{
    int max = array [0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] > max) max = array [i];
    }
    return max;
}

int [] arrayNew = arrayGen(array, minNum, maxNum);
var arrayView = string.Join(", ", arrayNew);
Console.WriteLine($"Дано массив: {arrayView}.");

int result = arrayMax(arrayNew) - arrayMin(arrayNew);
Console.WriteLine($"Разница между максимальным числом '{arrayMax(arrayNew)}' и минимальным числом '{arrayMin(arrayNew)}' составляет '{result}'.");