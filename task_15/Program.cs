// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


System.Console.WriteLine("input day ");
int Day = Convert.ToInt32(Console.ReadLine());

if (Day > 1 && Day < 8)
{
    if (Day == 6 || Day == 7)
    {
        System.Console.WriteLine("yes");
    }
    else
    {
        System.Console.WriteLine("no");
    }
}
else
{
    System.Console.WriteLine("day < 1 or > 7");
}
