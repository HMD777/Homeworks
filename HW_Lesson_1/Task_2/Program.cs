Console.WriteLine("Введите номер недели:");
int num = int.Parse(Console.ReadLine());
if (num < 0 | num > 7)
{
    Console.WriteLine("Вы ввели не существуюущий номер недели!");
}
else
{
    if (num == 1) Console.WriteLine("Понедельник");
    if (num == 2) Console.WriteLine("Вторник");
    if (num == 3) Console.WriteLine("Среда");
    if (num == 4) Console.WriteLine("Четверг");
    if (num == 5) Console.WriteLine("Пятница");
    if (num == 6) Console.WriteLine("Суббота");
    if (num == 7) Console.WriteLine("Воскресенье");
}