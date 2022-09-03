Console.WriteLine("В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]!");
int [] array = new int [123];

int [] arrayGen (int [] arr, int min, int max)
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
        {
            arr [i] = random.Next(min, max);
        }
    return arr;
}

int countInArray (int [] array, int minNum, int maxNum)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i] <= maxNum && array[i] >= minNum)
                {
                    result ++;
                }
        }
    return result;
}

int [] array2 = arrayGen(array, 1, 123);
var arrView = string.Join(", ", array2);
Console.WriteLine($"Дано массив: {arrView}!");

int find = countInArray(array2, 10, 99);
Console.WriteLine($"В текущем массиве, количество элементов чисел из отрезка [10, 99] составляет: '{find}'!");