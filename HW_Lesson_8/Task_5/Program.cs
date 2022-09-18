Console.WriteLine("Написать программу возведения числа А в целую стень B");
Console.WriteLine("Введите число которое необходимо вовзести в степень: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Введение степень к предыдущему числу: ");
int sqrt = int.Parse(Console.ReadLine());

void NumSqrt(int num, int sqrt)
{
    double result = 1;
    if (sqrt > 0)
    {
        for (int i = 0; i < sqrt; i++)
        {
            result = result * num;
        }
        Console.WriteLine($"Результат высичления {num}^{sqrt} = {result}.");
    }
    else
    {
        for (int i = 0; i < -sqrt; i++)
        {
            result = result * num;
        }
        Console.WriteLine($"Результат высичления {num}^{sqrt} = {1/result}.");
    }


}

NumSqrt(num, sqrt);