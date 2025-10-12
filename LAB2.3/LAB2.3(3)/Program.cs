Console.WriteLine("Введите x: ");
double x = double.Parse(Console.ReadLine());
double b = -4.5;
double m = 0.5;
double n = -1.5;
double z = Math.Abs(b * m);
double y;
if (z > Math.Pow(x, 2)) { y = Math.Sin(b * m + Math.Cos(n * x)); Console.WriteLine("y= " + y); }
if (z < Math.Pow(x, 2)) { y = Math.Cos(b * m - Math.Sin(x)); Console.WriteLine("y= " + y); }
if (z == Math.Pow(x, 2)) { y = Math.Sqrt(Math.Pow(Math.Log(10), Math.Abs(Math.Cos(x)))) + Math.Sqrt(Math.Abs(b * m * x)); Console.WriteLine("y= " + y); }
