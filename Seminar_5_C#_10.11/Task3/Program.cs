// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] array = new double [size];
    for (int i=0; i < size; i++)
    {   
        int a = new Random().Next(minValue, maxValue);
        double b = Math.Round(new Random().NextDouble(), 3);
        array[i] = a + b;
    }
    return array;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

double FindDiff(double[] array)
{
    double maxNumOfArray = 0;
    double minNumOfArray = 0;
    if (array[0] > array[1])
        {
            maxNumOfArray = array[0];
            minNumOfArray = array[1];
        }
        else
        {
            maxNumOfArray = array[1];
            minNumOfArray = array[0];
        }   
    for(int i = 2; i < array.Length; i++)
    {
        if (array[i]>maxNumOfArray)
            maxNumOfArray = array[i];
        if (array[i]<minNumOfArray)
            minNumOfArray = array[i];
    }
    Console.WriteLine($"Максимальное число = {maxNumOfArray}; минимальное равно {minNumOfArray}");
    double diff = Math.Round(maxNumOfArray-minNumOfArray, 3);
    return diff;
}


Console.Write("Введите число элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

if (n<=1)
    Console.WriteLine("В массиве один элемент. Разница равна 0");
else
{
    double[] myArray = CreateRandomArray(n,min,max);
    ShowArray(myArray);
    Console.WriteLine($"Разница между максимальным и минимальным элементом в массиве равна {FindDiff(myArray)}.");
}