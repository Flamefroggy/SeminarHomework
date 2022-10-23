// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// Квадрат диагонали прямоугольного параллелепипеда равен сумме квадратов трех его измерений.
// Значит diag == Math.Sqrt (x1-x2)2 + (y1-y2)2 + (z1-z2)2

double Dis(double x1, double y1, double x2, double y2, double z1, double z2)
{
    double parppdside1 = y1 - y2;
    double parppdside2 = x1 - x2;
    double parppdside3 = z1 - z2;
    double n = Math.Sqrt(parppdside1*parppdside1 + parppdside2*parppdside2 + parppdside3*parppdside3);
    return n;
}

Console.Write("Введите координаты первой точки по оси X: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты первой точки по оси Y: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты первой точки по оси Z: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты второй точки по оси X: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты второй точки по оси Y: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты второй точки по оси Z: ");
double z2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Расстояние между точками равно {Dis(x1,y1,x2,y2,z1,z2)}");