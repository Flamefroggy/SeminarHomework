// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumDigit(int number)
{
    if (number<0)
    number *= -1;
    int sum = 0;
    while (number != 0)
    {
        sum += number%10;
        number/=10;
    }
    return sum;
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Cумма цифр в числе {a} равна {SumDigit(a)}");