Console.WriteLine("Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран");
int [] array = new int[8];
Random random = new Random();
int max = 10;
int min = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(min, max);
}
var str = string.Join(" ", array);
Console.WriteLine($"Дано массив: '{str}'");

for (int i=0; i<array.Length; i++)
{
    if (array[i] == 0 || array[i] == 1)
    {
        Console.WriteLine($"Индекс массива '{i}' является '{array[i]}'!");
    }
}