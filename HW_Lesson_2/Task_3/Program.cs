Console.WriteLine("Задать номер четверти, показать диапазоны для возможных координат");
Console.WriteLine("Введите номер четверти: ");
int num = int.Parse(Console.ReadLine());
if (num == 1) 
{
    Console.WriteLine("Диапозон возможных координат для Первой четверти 'x > 0 и 'y > 0'!");
}
else if (num == 2)
{
    Console.WriteLine("Диапозон возможных координат для Второй четверти 'x > 0 и 'y < 0'!");
}
else if (num == 3)
{
    Console.WriteLine("Диапозон возможных координат для Третьей четверти 'x < 0 и 'y < 0'!");
}
else if (num == 4)
{
    Console.WriteLine("Диапозон возможных координат для Четвертой четверти 'x < 0 и 'y > 0'!");
}
else
{
    Console.WriteLine("Вы ввели не существующий номер четверти!");
}
