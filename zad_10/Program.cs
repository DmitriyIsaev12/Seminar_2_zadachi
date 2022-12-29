// Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

Console.WriteLine(" Задайте трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 1000 && a > 99)
{
int two = a / 10;
int result = two % 10;
Console.Write(result);
}
else
Console.WriteLine("Вы ввели не трехзначное число,  введите трехзначное");
