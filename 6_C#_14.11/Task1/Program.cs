// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int Count(int number)
{
    int count = 0;
    for (int i = 1; i<=number; i++)
    {
        if (i%10 == 3 && i % 100 != 13)
        {
            Console.Write($"Введите {i}-ье число на проверку: "); 
        }
        else
        {
            Console.Write($"Введите {i}-ое число на проверку: ");
        }
        int a = Convert.ToInt32(Console.ReadLine());
        if (a>0)
            count += 1;
    }
    return count;
}

Console.Write("Укажите количество чисел, которые вы введёте: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Из {n} введённых вами чисел {Count(n)} из них положительные.");