Console.WriteLine("Дано число из отрезка [10, 99]. Показать наибольшую цифру числа");
Console.WriteLine("Введите любое число от 10 до 99:");
int num = int.Parse(Console.ReadLine());
if (num >9 && num <100)
{
    int num_1 = num;
    int resultNum1 = 0;
    int resultNum2 = num%10;
    int max = resultNum2;
    while (num_1>10)
   {
    num_1 = num_1/10;
    resultNum1 = num_1%10;
   }
    if (resultNum1>max)
    {
        max = resultNum1;
    }
     
    Console.WriteLine("Наибольшая цифра из числа '" + num + "' является '" + max + "'");
}
else
{
    Console.WriteLine("Вы ввели не верные данные!");
}