Console.WriteLine("Показать кубы чисел, заканчивающихся на четную цифру");
Console.WriteLine("Введите длинну массива: ");
int arrLength = int.Parse(Console.ReadLine()); 
int[] array = new int[arrLength];
int min = 0;
int max = 10;
Random random = new Random();
for (int i=0; i<array.Length; i++)
{
    array[i] = random.Next(min, max);
}
var str = string.Join(" ", array);
Console.WriteLine($"Данные массива '{str}'");

for (int i=0; i<=array.Length; i++)
{
    if (array[i]>0)
    {
        double result = Math.Pow(array[i],3) % 2;
        if (result == 0) 
        Console.WriteLine($"Куб числа '{array[i]}' равен '{Math.Pow(array[i],3)}' и заканчивается на четную цифру!");
    }
}