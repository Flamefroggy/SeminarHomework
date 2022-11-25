// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int AckerFunk (int m, int n)
{
    if (m == 0) return n + 1;
    if ((m != 0) && (n == 0))
    {
        return AckerFunk(m - 1, 1);
    }
    else return (AckerFunk(m - 1, AckerFunk(m, n - 1)));
}

Console.Write("Введите натуральное значение m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите натуральное значение n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Значение функции Аккермана для чисел {m}(m) и {n}(n) = {AckerFunk(m, n)}");