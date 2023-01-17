// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// 1
System.Console.WriteLine("input num1");
string num1 = Console.ReadLine();
if (num1.Length < 3)
{
    System.Console.WriteLine("num1 < 3");
}
else
{
    System.Console.WriteLine(Int32.Parse($"{num1[2]}"));
}


// 2
System.Console.WriteLine("input num2");
int num2 = Convert.ToInt32(Console.ReadLine());
int result = -1;
if (num2 >= 100)
{
    while (num2 > 999)
    {
        num2 = num2 / 10;
    }
    result = num2 % 10;
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("num2 < 3");
}
