// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.


int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i<rows; i++)
        for (int j = 0; j<columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue+1);
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");

        Console.WriteLine();
    }
    Console.WriteLine();
}

int FindWeakestRow(int[,] array)
{
    int row = 0, sum = 0, min = 0;
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
            sum += array[i,j];
        if (i==0) min = sum;  
        if (sum<min) 
        {
            min = sum;
            row = i+1;
        }
        sum = 0;
    }
    return row;
}

Console.Write("Input a number of rows: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimum value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maximum value: ");
int max = Convert.ToInt32(Console.ReadLine());


int[,] myArray = CreateRandom2dArray(r,c,min,max);
Show2dArray(myArray);
Console.WriteLine($"Наименьшая сумма находится в строке под номером {FindWeakestRow(myArray)}.");