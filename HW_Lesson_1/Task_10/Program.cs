Console.WriteLine("Найти третью цифру числа или сообщить, что её нет");
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
if (num>99)
{
    int div = 1;
    if (num >999) div = 10;
    if (num >9999) div = 100;
    if (num >99999) div = 1000;
    Console.WriteLine("Третья цифра введенного числа является: " + (num/div)%10);
    if (num >999999) Console.WriteLine("Вы ввели слишком большое число!");
}
else
{
    Console.WriteLine("В введенном числе, отсутствует третья цифра!");
}