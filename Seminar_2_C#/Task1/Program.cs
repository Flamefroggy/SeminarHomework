// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int Sd(int number)
{
    int secondDigit = number / 10 % 10;
    return secondDigit;
}
Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"В числе {number} второй цифрой является {Sd(number)}.");
