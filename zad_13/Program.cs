//Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

Console.WriteLine("Задайте число");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 100)
 {
    Console.Write("В данном числе третьей цифры нет");
 }
else
{
while (a >= 1000)
{
    a = a / 10;
}

if (a < 1000)
 { 
    int three = a % 100;
    int tow = three % 10;
    Console.Write(tow);
 }
 }
