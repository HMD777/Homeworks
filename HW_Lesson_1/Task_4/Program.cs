Console.WriteLine("Выяснить является ли число чётным");
Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());
if (num%2==0)
{
    Console.WriteLine("Введенное число '" + num + "' является четным!");
}
else
{
     Console.WriteLine("Введенное число '" + num + "' неявляется четным!");
}