//Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

Console.WriteLine("Задайте число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте число B");
int b = Convert.ToInt32(Console.ReadLine());
int degree  = a;

for (int i = 1; i < b; i++)
{
degree = degree * a;
}
Console.WriteLine("A в степени B равно: " + degree);
