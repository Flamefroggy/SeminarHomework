// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


int[,,] CreateRandom3dArray(int rows, int columns, int depth)
{
    int[,,] array = new int[rows, columns, depth];
    if (rows*columns*depth<=90)
    {
        int[] repeatCheck = new int[rows*columns*depth];
        int l = 0;
        int count = 0;
        for(int i = 0; i<rows; i++)
            for (int j = 0; j<columns; j++)
                for (int k = 0; k<depth; k++, l++)
                {
                    array[i,j,k] = new Random().Next(10,100);
                    repeatCheck[l] = array[i,j,k];
                        for (int m = 1; m < l; m++)
                        {
                            if (repeatCheck[m] == array[i,j,k])
                            {
                                count++;
                                Console.WriteLine($"{l+1}-е число в проверочном массиве. Было {count} повторений. Число {repeatCheck[m]} уже есть в массиве.");
                                l--;
                                k--;
                                break;
                            }  
                        }        
                }
        ShowArray(repeatCheck);
        Console.WriteLine();

        return array;
    }
    else 
    {
        Console.WriteLine("There is not enough numbers for your array!");
        return array;
    }
}

void Show3dArray(int[,,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
        {
        for (int j = 0; j<array.GetLength(1); j++)
            for (int k = 0; k<array.GetLength(2); k++)
            {
                Console.Write(array[i,j,k] + $" ({i},{j},{k})" + "\t");
            }
        Console.WriteLine();
        }
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "\t");

    Console.WriteLine();
}

Console.Write("Input a number of rows: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of elements in depth: ");
int d = Convert.ToInt32(Console.ReadLine());

int[,,] myArray = CreateRandom3dArray(r,c,d);
Show3dArray(myArray);
Console.WriteLine();