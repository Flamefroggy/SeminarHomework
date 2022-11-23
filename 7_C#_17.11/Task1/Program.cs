// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] Array2D(int rows, int columns, int minValue, int maxValue)
{
    double[,] array2D = new double[rows, columns];
    for(int i = 0; i<rows; i++)
        for(int j = 0; j<columns; j++)
        {
            int rand = new Random().Next(minValue, maxValue+1);
            array2D[i,j] =  Math.Round(new Random().NextDouble()+rand, 3);
        }
        return array2D;
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input number of rows: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimum value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maximum value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] myNewArray = Array2D(r,c,min,max);
Show2dArray(myNewArray);