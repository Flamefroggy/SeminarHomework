// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.


int[,] CreateRandom2dArray()
{
    int[,] array = new int[5,5]; //нам неизвестны эти цифры и они могут быть любыми
                                 //я на них не опираюсь, просто чтобы было быстрее. 

    for(int i = 0; i<array.GetLength(0); i++)
        for (int j = 0; j<array.GetLength(1); j++)
            array[i,j] = new Random().Next(0, 100);
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

bool IsItReal(int[,] array, int a, int b)
{
    if (a-1<array.GetLength(0) && b-1<array.GetLength(1))
            return true;
    else return false;
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

Console.Write("Input the row number you're looking for: ");
int i1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the column number you're looking for: ");
int j1 = Convert.ToInt32(Console.ReadLine());
bool hoba = IsItReal(myArray, i1, j1);
    if (hoba == true) Console.WriteLine(myArray[i1-1,j1-1]);
    else Console.WriteLine("There is no element in your position");
