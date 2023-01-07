// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1

int n = InputInt("Задайте  положительное целое число:  ");
int k = 1;
if (n < 1)
{
    Console.WriteLine("Задано отрицательное число");
}
Console.WriteLine(Natural(n, k));

int Natural(int n, int k)
{
    if (n == k)
        return n;
    else
        Console.Write($"{Natural(n, k + 1)}, ");
    return k;
}
int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}