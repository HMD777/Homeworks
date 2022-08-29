Console.WriteLine("Дано число обозначающее день недели. Выяснить является номер дня недели выходным");
Console.WriteLine("Введите число дня недели: ");
int num = int.Parse(Console.ReadLine());
if (num > 0 && num <8)
{
    if (num == 6 || num == 7)
    {
        Console.WriteLine($"Введенное чтсло '{num}' является выходным!");
    }
    else
    {
        Console.WriteLine($"Введенное чтсло '{num}' не является выходным!");
    }
}
else
{
    Console.WriteLine($"Введенное чтсло '{num}' не является днем недели!");
}