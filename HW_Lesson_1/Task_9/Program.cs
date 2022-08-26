Console.WriteLine("Выяснить, кратно ли число заданному, если нет, вывести остаток.");
Console.WriteLine("Введите первое число (числитель): ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число (знаменатель): ");
int num2 = int.Parse(Console.ReadLine());
if (num%num2 == 0)
{
    Console.WriteLine("Первое число кратно второму числу!");
}
else
{
    Console.WriteLine("Первое число некратно второму числу, остаток равен: " + (num%num2));
}