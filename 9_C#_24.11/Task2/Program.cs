// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumBetwNums(int n, int m)
{
    if (m>n) return SumBetwNums(n, m-1) + m;
    return n;

}

Console.Write("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());
int c = 0;
if (a<b)
{
    c = SumBetwNums(a,b);
    Console.WriteLine($"Sum equals {c}.");
}
else if (b<a) 
{
    c = SumBetwNums(b,a);
    Console.WriteLine($"Sum equals {c}.");
}
else Console.WriteLine($"Sum equals {a}.");

