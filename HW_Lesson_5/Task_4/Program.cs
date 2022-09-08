Console.WriteLine("Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы");
Console.WriteLine("Введите данные для решения упавнения: ");
Console.WriteLine("Введите b1: ");
int b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b2: ");
int b2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите k1: ");
int k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите k2: ");
int k2 = int.Parse(Console.ReadLine());

int solverX (int b1, int b2, int k1, int k2)
{
    int result = (b2-b1)/(k1-k2);
    return result;
}

int solverY (int k2, int x, int b2)
{
    int result = k2*x+b2;
    return result;
}

int x = solverX(b1, b2, k1, k2);
int y = solverY(k2, x, b2);

Console.WriteLine($"Точка пересечения двух прямых будет ({x}, {y})");