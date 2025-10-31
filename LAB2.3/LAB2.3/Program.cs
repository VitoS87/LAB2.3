﻿Console.WriteLine("Введите x: ");
double x = double.Parse(Console.ReadLine());
Console.WriteLine("Выберите вариант входных параметров (1,2 или 3): ");
int c = int.Parse(Console.ReadLine());
double y;
double b;
double m;
double n;
double z;
int k;
switch (c)
{
    case 1:
        b = -1.6;
        m = 0.9;
        n = -1.4;
        z = Math.Abs(b * m);
        k = 0;
        if (z > Math.Pow(x, 2)) { k = 1; }
        if (z < Math.Pow(x, 2)) { k = 2; }
        if (z == Math.Pow(x, 2)) { k = 3; }
        switch (k)
        {
            case 1:
                y = Math.Sin(b * m + Math.Cos(n * x)); Console.WriteLine("y= " + y); break;
            case 2:
                y = Math.Cos(b * m - Math.Sin(x)); Console.WriteLine("y= " + y); break;
            case 3:
                y = Math.Sqrt(Math.Pow(Math.Log(10), Math.Abs(Math.Cos(x)))) + Math.Sqrt(Math.Abs(b * m * x)); Console.WriteLine("y= " + y); break;
        }
        break;
    case 2:
        b = 4.5;
        m = -2;
        n = 2.2;
        z = Math.Abs(b * m);
        k = 0;
        if (z > Math.Pow(x, 2)) { k = 1; }
        if (z < Math.Pow(x, 2)) { k = 2; }
        if (z == Math.Pow(x, 2)) { k = 3; }
        switch (k)
        {
            case 1:
                y = Math.Sin(b * m + Math.Cos(n * x)); Console.WriteLine("y= " + y); break;
            case 2:
                y = Math.Cos(b * m - Math.Sin(x)); Console.WriteLine("y= " + y); break;
            case 3:
                y = Math.Sqrt(Math.Pow(Math.Log(10), Math.Abs(Math.Cos(x)))) + Math.Sqrt(Math.Abs(b * m * x)); Console.WriteLine("y= " + y); break;
        }
        break;
    case 3:
        b = -4.5;
        m = 0.5;
        n = -1.5;
        z = Math.Abs(b * m);
        k = 0;
        if (z > Math.Pow(x, 2)) { k = 1; }
        if (z < Math.Pow(x, 2)) { k = 2; }
        if (z == Math.Pow(x, 2)) { k = 3; }
        switch (k)
        {
            case 1:
                y = Math.Sin(b * m + Math.Cos(n * x)); Console.WriteLine("y= " + y); break;
            case 2:
                y = Math.Cos(b * m - Math.Sin(x)); Console.WriteLine("y= " + y); break;
            case 3:
                y = Math.Sqrt(Math.Pow(Math.Log(10), Math.Abs(Math.Cos(x)))) + Math.Sqrt(Math.Abs(b * m * x)); Console.WriteLine("y= " + y); break;
        }
        break;
    default:
        Console.WriteLine("Выбран неверный вариант входных параметров");
        break;
}
