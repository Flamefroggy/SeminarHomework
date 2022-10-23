// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
bool Palyndrome(int number)
{
    int changing = number;
    int secondNumber = 0;
    while (changing > 0)
    {
        secondNumber = secondNumber * 10 + changing % 10;
        changing = changing / 10;
    }
    if (secondNumber == number)
    return true;
    else return false;
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
bool paly = Palyndrome(number);
if (paly == true)
    Console.WriteLine($"Вау! Число {number} палиндром!");
else
    Console.WriteLine($"Увы, число {number} не палиндром");

