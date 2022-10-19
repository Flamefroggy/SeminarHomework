// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
bool Dotw(int dn)
{
    if (dn < 6)
        return false;
    else 
        return true;
}

Console.Write("Введите цифру, обозначающую день недели (1-7): ");
int dn = Convert.ToInt32(Console.ReadLine());
bool weekend = Dotw(dn);
if(dn<8)
{
    if(weekend == true)
        Console.WriteLine("Да, этот день является выходным");
    else
        Console.WriteLine("Нет, это будний день");
}
else
    Console.WriteLine("Перечитай условия");

