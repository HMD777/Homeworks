Console.WriteLine("Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива");
Console.WriteLine("Введите минимальное число массива: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное число массива: ");
int max = int.Parse(Console.ReadLine());

int [] array = new int [12];
Random random = new Random();
int sumpositive = 0;
int sumnegative = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(min, max);
}

var str = string.Join(", ", array);
Console.WriteLine($"Дано массивы из следующих чисел: '{str}'.");

for (int i = 0; i < array.Length; i++)
{

    if (array[i] > 0)
    {
        sumpositive += array[i];
    }
    else
    {
        sumnegative += array[i];
    }
}
Console.WriteLine($"Сумма положительных чисел: '{sumpositive}'.");
Console.WriteLine($"Сумма негативных чисел: '{sumnegative}'.");