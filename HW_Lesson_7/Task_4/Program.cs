Console.WriteLine("Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника");
Console.Write("Введите количество строк: ");
int num = int.Parse(Console.ReadLine());

for (int i = 0; i < num; i++)
{
    int count = 1;
    for (int j = 0; j < num - i; j++)
    {
        Console.Write("  ");
    }

    for (int k = 0; k <= i; k++)
    {
        Console.Write("  {0:D} ", count);
        count = count * (i - k) / (k + 1);
    }
    Console.WriteLine();
}
