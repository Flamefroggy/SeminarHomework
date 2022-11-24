// Напишите программу, которая заполнит спирально массив.

int[,] MakeASnail(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    int border = rows*columns;
        for (int iteratio = 0, order = 1; order<=border; iteratio++)
        {   
            for (int c = iteratio, d = iteratio; d < columns-iteratio && order<=border; d++)
                {   
                    // Console.WriteLine($"Первый цикл {c} {d}");
                    array[c,d] = order; 
                    order++;
                }
            for (int e = iteratio+1, f = columns-iteratio-1; e < rows-iteratio && order<=border; e++)
                {   
                    // Console.WriteLine($"Второй цикл {e} {f}");
                    array[e,f] = order; 
                    order++;
                }
            for (int g = rows-iteratio-1, h = columns-iteratio-2; h >= iteratio && order<=border; h--)
                {   
                    // Console.WriteLine($"Третий цикл {g} {h}");
                    array[g,h] = order; 
                    order++;
                }
            for (int i = rows-iteratio-2, j = iteratio; i > iteratio && order<=border; i--)
                {  
                    // Console.WriteLine($"Четвертый цикл {i} {j}");
                    array[i,j] = order; 
                    order++;
                }
        }
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

Console.Write("Input a number of rows: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int c = Convert.ToInt32(Console.ReadLine());

int[,] myArray = MakeASnail(r,c);
Show2dArray(myArray);

