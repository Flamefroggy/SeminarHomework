// Задача №3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 1)
{
    Console.WriteLine($"Число {number} является нечётным");
}
else
{
    Console.WriteLine($"Число {number} является чётным");
}