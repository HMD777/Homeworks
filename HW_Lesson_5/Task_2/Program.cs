Console.WriteLine("Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");

Console.WriteLine("Введите длинну массива: ");
int num = int.Parse(Console.ReadLine());

int minNum = 100;
int maxNum = 1000;

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

int countOdd (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] % 2 != 0) count++;
    }
    return count;
}

int [] fillArrayOdd (int [] array, int [] arrayOdd)
{
    int j = 0;
    for (int i =0; i < array.Length; i++)
    {
        
        if (array [i] % 2 != 0)
        {
            arrayOdd[j] = array [i];
            j++;
        }
    }
    return arrayOdd;
}

int arraySum (int [] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        result += array [i];
    }
    return result;
}
int [] newArray = arrayGen(array, minNum, maxNum);
int arrayOddLength = countOdd(newArray);
int [] arrayOdd = new int [arrayOddLength];
int [] newArrayOdd = fillArrayOdd(newArray, arrayOdd);
var arrayView = string.Join(", ", newArray);
var arrayViewOdd = string.Join(", ", newArrayOdd);
int sumResult = arraySum(newArrayOdd);
Console.WriteLine($"Дано массив из следующих чисел: {arrayView}.");
Console.WriteLine($"Из них нечетными числами являются: {arrayViewOdd}.");
Console.WriteLine($"Сумма нечетных чисел равна: {sumResult}.");