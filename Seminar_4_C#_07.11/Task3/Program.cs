// Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
int[] GenerateArray(int size)
{
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        if (i%10 == 2 && i % 100 != 12)
        {
            Console.WriteLine($"Введите {i+1}-ье число: "); 
        }
        else
        {
            Console.WriteLine($"Введите {i+1}-ое число: ");
        }
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    Console.Write("А вот и массив: ");

    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

Console.Write("Введите число элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = GenerateArray(n);
ShowArray(array);