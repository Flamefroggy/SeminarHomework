// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.


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

int[,] ChangedArray(int[,] array)
{
    for (int i = 0; i<array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(1)-1; k++)
            {
                if (array[i,k+1] > array[i,k])
                {
                    int temp = array[i,k];
                    array[i,k] = array[i,k+1];
                    array[i,k+1] = temp;
                }
            }
    return array;
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
ChangedArray(myArray);
Show2dArray(myArray);
                                    