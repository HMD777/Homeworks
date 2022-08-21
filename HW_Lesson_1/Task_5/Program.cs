Console.WriteLine("Показать четные числа от 1 до N");
Console.WriteLine("Введите любое число от 1 и больше:");
int num = int.Parse(Console.ReadLine());

if (num >1)
    {
        int count = 1;
        while (count<=num)
            {
                if (count%2==0)
                {
                    Console.WriteLine("Число '"+count+"' является четным.");
                } 
            count++;
            }
    }
else
    {
        Console.WriteLine("Вы ввели не правильные данные!");
    }