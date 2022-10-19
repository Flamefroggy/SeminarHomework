// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int Cut(int number)
{   
    while (number >= 1000 || number <= -1000)
    {
        number = number / 10;
    }
    int result = number % 10;
    if (result < 0)
        result = result * -1;
    return result;
 }

Console.Write("Write a number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 && number > -100)
{
    Console.WriteLine($"В числе {number} нет третьей цифры =(");
}
else
{
    Console.WriteLine($"В числе {number} третьей цифрой является цифра {Cut(number)}");
}
