Console.WriteLine("Удалить вторую цифру трёхзначного числа!");
Console.WriteLine("Введите трехзначное число:");
int num = int.Parse(Console.ReadLine());
if (num > 99 && num < 1000)
{
    Console.WriteLine("Результат 1: "+(num/100)%10 + "_" +(num%10));
}
else
{
    Console.WriteLine("Вы ввели не верные данные!");
}