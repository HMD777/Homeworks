Console.WriteLine("Показать вторую цифру трёхзначного числа");
Console.WriteLine("Введите трехзначное число:");
int num = int.Parse(Console.ReadLine());
if (num>99 && num <1000)
{
    int num_1=num;
    int result = 0;
    int result_1=0;
    int result_2=0;
    while (num_1>11)
    {
        num_1 = num_1 / 10;
        result = num_1 % 10;
    }
    result_1 = (num-(result*100));
    while (result_1>11)
    {
        result_1 = result_1 / 10;
        result_2 = result_1 % 10;
    }
    Console.WriteLine("Результат: "+result_2);
}
else
{
    Console.WriteLine("Вы ввели не верные данные!");
}