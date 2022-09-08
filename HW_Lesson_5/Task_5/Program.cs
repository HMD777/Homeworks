// See https://aka.ms/new-console-template for more information
Console.WriteLine("Написать программу масштабирования фигуры");
Console.WriteLine("Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой) ");
Console.WriteLine("например: '(0,0) (2,0) (2,2) (0,2)' коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5 ");
Console.WriteLine("В результате показать координаты, которые получатся. при k = 2 получаем '(0,0) (4,0) (4,4) (0,4)'");

Console.WriteLine("Введите высоту фигуры: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите ширину фигуры: ");
int y = int.Parse(Console.ReadLine());

int [] xAxis = {0, x, x, 0};
int [] yAxis = {0, 0, y, y};

int [] scale (int [] array, int scale, int [] arrayNew)
{
    for (int i = 0; i < array.Length; i++)
    {
        arrayNew [i] = array [i] * scale;
        
    }
    return arrayNew;
}

if ( x > 0 && y > 0)
{
    Console.WriteLine($"Дано данные фигуры '({xAxis[0]}, {yAxis[0]}) ({xAxis[1]}, {yAxis[1]}) ({xAxis[2]}, {yAxis[2]}) ({xAxis[3]}, {yAxis[3]})'");
    Console.WriteLine("На сколько увеличить фигуру?");
    int z = int.Parse(Console.ReadLine());

    if ( z < 0) 
        {
            Console.WriteLine("Ошибка! Вы ввели данные на уменьшение фигуры!");
        }
        else
        {
            int [] xAxis2 = new int [xAxis.Length];
            int [] yAxis2 = new int [yAxis.Length];
            int [] xAxisNew = scale(xAxis, z, xAxis2);
            int [] yAxisNew = scale(yAxis, z, yAxis2);
            Console.WriteLine($"Даные увеличенной фигуры '({xAxisNew[0]}, {yAxisNew[0]}) ({xAxisNew[1]}, {yAxisNew[1]}) ({xAxisNew[2]}, {yAxisNew[2]}) ({xAxisNew[3]}, {yAxisNew[3]})'");
        }
}
else
{
    Console.WriteLine("Длинна или ширина фигуры не может быть отрицательной!");
}

