// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


int[,] CreateRandom2dArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; ++i)
        for (int j = 0; j < columns; ++j)
            array[i, j] = new Random().Next(1, 100);
    return array;
}

void Show2dArray(int[,] array)
{    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] AvgArr(int[,] array)
{
    double[] avgArray = new double[array.GetLength(1)];
    for (int i = 0; i < avgArray.Length; ++i)
    {
        double sum = 0;
        for(int j = 0; j < array.GetLength(0); ++j)
        sum += array[j, i];
        avgArray[i] = sum / array.GetLength(0);
    }
    return avgArray;
}

void ShowAvgArray(double[] array)
{
    for (int i = 0; i < array.Length; ++i)
        Console.Write(Math.Round(array[i], 3) + "\t");
    Console.WriteLine();
}

Console.Write("Input a number of rows: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int c = Convert.ToInt32(Console.ReadLine());


int[,] myArray = CreateRandom2dArray(r, c);
Show2dArray(myArray);

ShowAvgArray(AvgArr(myArray));