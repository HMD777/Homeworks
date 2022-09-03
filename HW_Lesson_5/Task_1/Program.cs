Console.WriteLine("Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");

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

int countEven (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] % 2 == 0) count++;
    }
    return count;
}

int [] fillArrayEven (int [] array, int [] arrayEven)
{
    int j = 0;
    for (int i =0; i < array.Length; i++)
    {
        
        if (array [i] % 2 == 0)
        {
            arrayEven[j] = array [i];
            j++;
        }
    }
    return arrayEven;
}

int [] newArray = arrayGen(array, minNum, maxNum);
int arrayEvenLength = countEven(newArray);
int [] arrayEven = new int [arrayEvenLength];
int [] newArrayEven = fillArrayEven(newArray, arrayEven);
var arrayView = string.Join(", ", newArray);
var arrayViewEven = string.Join(", ", newArrayEven);
Console.WriteLine($"Дано массив из следующих чисел: {arrayView}.");
Console.WriteLine($"Из низ четными числами являются: {arrayViewEven}.");

