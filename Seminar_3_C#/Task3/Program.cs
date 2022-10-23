// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Coub(int number)
{
    int count = 1;
    Console.Write($"Последовательность кубов до числа {number}: ");
    while (count <= number)
    {
        if (count == number) 
        {   
            Console.Write($"{count*count*count}.");
            break;
        }
        else
        {
            Console.Write($"{count*count*count}, ");
            count++;
        }
    }
}


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Coub(number);
