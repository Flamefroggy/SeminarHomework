// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

int Multiply(int a, int b)
{
    int st = 1;
    for (int i=1; i <= b; i++)
    {
        st *= a;
    }
    return st;
}


Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите степень, в которую надо возвести число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {a} в степени {b} равно {Multiply(a,b)}");