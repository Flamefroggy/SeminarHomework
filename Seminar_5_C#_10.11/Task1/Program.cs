// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateRandomArray(int size)
{
    int[] array = new int [size];

    for (int i=0; i < size; i++)
        array[i] = new Random().Next(100, 999);
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int NumOfEven(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            count += 1;
    return count;
}

Console.Write("Введите число элементов: ");
int n = Convert.ToInt32(Console.ReadLine());


int[] myArray = CreateRandomArray(n);
ShowArray(myArray);
Console.WriteLine($"Количество четных чисел в массиве: {NumOfEven(myArray)}.");