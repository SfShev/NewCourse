void Distance(double x, double y, double x1, double y1)

{
    double a = (x - x1);
    double b = (y - y1);
    double distance = Math.Sqrt(a * a + b * b);
    Console.WriteLine($"Расстояние = {distance} ");
}


Console.WriteLine("Задайте координаты");
Console.WriteLine("Координаты 1 точки");
Console.Write("Х = ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Y = ");
double y = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Координаты 2 точки");
Console.Write("Х = ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Y = ");
double y1 = Convert.ToDouble(Console.ReadLine());


Distance(x, y, x1, y1);
Console.WriteLine();