Console.WriteLine("Написать программу копирования массива");
Console.WriteLine("Введите длинну массива: ");
int len = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное число массива: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное число массива: ");
int max = int.Parse(Console.ReadLine());

int [] arrayGen (int [] array, int min, int max)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = random.Next(min, max);
    }
    return array;
}

int [] arrayCopy (int [] oldArray, int [] newArray)
{
    for (int i = 0; i < oldArray.Length; i++)
    {
        newArray [i] = oldArray [i];
    }
    return newArray;
}

int [] array = new int [len];
int [] arrayGererated = arrayGen(array, min, max);
int [] arrayNew = new int [arrayGererated.Length];
int [] arrayCopied = arrayCopy (arrayGererated, arrayNew);

var array1 = string.Join(", ", arrayGererated);
var array2 = string.Join(", ", arrayCopied);
Console.WriteLine($"Сгенерирован массив: '{array1}'");
Console.WriteLine($"Скопирован массив: '{array2}'");