Console.WriteLine("Определить, присутствует ли в заданном массиве, некоторое число");

Console.WriteLine("Введите искомое число от 1 до 10: ");
int num = int.Parse(Console.ReadLine());

int [] array = new int[10];

int [] arrayGen (int [] arr, int min, int max)
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
        {
            arr [i] = random.Next(min, max);
        }
    return arr;
}

void findInArray (int [] array, int num)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == num)
                {
                    Console.WriteLine($"Искомое число '{num}' имеется в текущем массиве под индексом №{i}!");
                    j ++;
                }
        }
    if (j == 0) Console.WriteLine($"Искомое число '{num}' отсутствует в текущем массиве!");
}

if (num < 11 && num > 0)
{
    int [] array2 = arrayGen(array, 1, 10);
    var arrView = string.Join(", ", array2);
    Console.WriteLine($"Дано массив: {arrView}!");
    findInArray(array2, num);
}
else 
{
    Console.WriteLine("Вы ввели не верные данные!");
}