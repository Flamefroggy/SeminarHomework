// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] CreateMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i<rows; i++)
        for (int j = 0; j<columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue);
    return array;
}

void ShowMtrx(int[,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");

        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] ProdMtrx(int[,] mtrx1, int[,] mtrx2)
{
    int [,] multimtrx = new int[mtrx1.GetLength(0),mtrx2.GetLength(1)];
    if (mtrx1.GetLength(1) == mtrx2.GetLength(0))
    {
        for (int i = 0; i < mtrx1.GetLength(0); i++)
            for (int j = 0; j < mtrx2.GetLength(1); j++)
            {
                multimtrx[i, j] = 0;
                for (int k = 0; k < mtrx1.GetLength(1); k++)
                    multimtrx[i, j] += mtrx1[i, k] * mtrx2[k, j];
            }
        return multimtrx;
    }
    else
    return mtrx1;
}

Console.Write("Input a number of rows of first matrix: ");
int r1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns of first matrix: ");
int c1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of rows of second matrix: ");
int r2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns of second matrix: ");
int c2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimum value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maximum value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] firstMtrx = CreateMatrix(r1,c1,min,max);
int[,] secondMtrx = CreateMatrix(r2,c2,min,max);;
int[,] multi = ProdMtrx(firstMtrx,secondMtrx);
ShowMtrx(firstMtrx);
ShowMtrx(secondMtrx);

if (ProdMtrx(firstMtrx,secondMtrx) == firstMtrx)
Console.WriteLine("Matrix multiplication is imposible!");
else ShowMtrx(multi);