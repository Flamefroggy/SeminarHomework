// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// k1x+b1 = k2x+b2                  ax+b=cx+d
// k1x-k2x = b2-b1                  ax-cx=d-b
// x = (b2-b1) / (k1-k2)            double x = (d-b)/(a-c);

void LinFunc(double a, double b, double c, double d)
{
    if (a==c && b!=d) Console.WriteLine("Прямые параллельны и не имеют точек пересечения!"); 
    else if (a==c && b==d) Console.WriteLine("Ого, прямые совпадают!");
    else
    {
        double x = (d-b)/(a-c);
        double y = a*x+b;
        // if (a*x+b != c*x+d) Console.WriteLine("Что-то не так, перепроверь..."); не всегда работает
        // Уже узнал, почему, хехе
        Console.WriteLine($"Точки пересечения заданных прямых: x = {x}, а y = {y}.");
    }
}
Console.Write("Введите угловой коффициент первой прямой (k1): ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите свободный член первой прямой (b1): ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите угловой коффициент второй прямой (k2): ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите свободный член второй прямой (b2): ");
double b2 = Convert.ToDouble(Console.ReadLine());
LinFunc(k1,b1,k2,b2);

