// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


// 1
System.Console.WriteLine("input num1");
string num1 = Console.ReadLine();
System.Console.WriteLine(Int32.Parse($"{num1[1]}"));


// 2
System.Console.WriteLine("input num2");
int num2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(num2 % 100 / 10);
