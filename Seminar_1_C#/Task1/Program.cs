// Задача №1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите первое целое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber > secondNumber)
{
    Console.WriteLine($"Число {firstNumber} больше, чем число {secondNumber}.");
}
else if(firstNumber < secondNumber)
{
    Console.WriteLine($"Число {secondNumber} больше, чем число {firstNumber}.");
}
else 
{
    Console.WriteLine($"Числа {firstNumber} и {secondNumber} равны. Вот это поворот!");
}