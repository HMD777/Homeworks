﻿Console.WriteLine("Найти расстояние между точками в пространстве 2D/3D");
Console.WriteLine("Введите координаты Xa: ");
double Xa = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты Xb: ");
double Xb = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты Ya: ");
double Ya = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты Yb: ");
double Yb = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты Za: ");
double Za = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты Zb: ");
double Zb = double.Parse(Console.ReadLine());
Console.WriteLine($"Найти расстояние между точками A ({Xa}, {Ya}, {Za}) и B ({Xb}, {Yb}, {Zb}) в пространстве: ");
double result = Math.Sqrt(Math.Pow((Xb-Xa),2)+Math.Pow((Yb-Ya),2)+Math.Pow((Zb-Za),2));
Console.WriteLine($"Расстояние между точками в пространстве составляет: '{result}'!");