//Задача №2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

int max = firstNumber;
if(secondNumber > firstNumber)
    {
        max = secondNumber;
    }
if(thirdNumber > secondNumber)
    {
        max = thirdNumber;
    }
    Console.WriteLine($"Число {max} является наибольшим!");




// if(firstNumber > thirdNumber)
//         {
//             Console.WriteLine($"Число {firstNumber} является наибольшим");
//         }
//         else if (firstNumber < thirdNumber)
//         {
//             Console.WriteLine($"Число {thirdNumber} является наибольшим");
//         }
//         else
//         {
//             Console.WriteLine($"Числа {thirdNumber} и {firstNumber} являются наибольшими. Вау!");
//   Тут я запутался... Типа, а зачем я объявлял max вообще, короче, сделал так...Задача же выполнена)
