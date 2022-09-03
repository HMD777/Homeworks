Console.WriteLine("Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.");

Console.WriteLine("Введите длинну массива: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное число массива: ");
int minNum = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное число массива: ");
int maxNum = int.Parse(Console.ReadLine());

int [] array = new int [num];

int [] arrayGen (int [] arr, int min, int max)
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
        {
            arr [i] = random.Next(min, max);
        }
    return arr;
}

void func (int [] array)
{
    int j = array.Length;
    int result = 0;
    for (int i = 0; i <= (array.Length)/2; i++)
    {
        result = array[i] * array[j-1];
        j--;
        Console.WriteLine($"{array[i]} * {array[j]} = {result}");
    }
}

int [] array2 = arrayGen(array, minNum, maxNum);
var arrView = string.Join(", ", array2);
Console.WriteLine($"Дано массив: {arrView}!");

Console.WriteLine("Результат:");
func(array2);