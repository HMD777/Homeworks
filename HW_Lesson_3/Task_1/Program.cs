Console.WriteLine("Найти кубы чисел от 1 до N.");
Console.WriteLine("Введите число: ");
double num = double.Parse(Console.ReadLine());
double i = 1;
double result = 0;
while (i<=num)
{
    result = Math.Pow(i, 3);
    Console.WriteLine($"{i}^3 = {result};");
    i++;
}