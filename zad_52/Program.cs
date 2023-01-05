//Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
//                 1 4 7 2
//                 5 9 2 3
//                 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Задайте количество строк");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте количество столбцов");
int b = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[a, b];
FillArrayRandomNumbers(numbers);


for (int j = 0; j < numbers.GetLength(1); j++)
{
    double midl = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        midl = (midl + numbers[i, j]);
    }
    midl = midl / a;
    Console.Write(" "+ midl + ";");
}
Console.WriteLine();
PrintArray(numbers);



void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("++ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " "+"|");
        }
        Console.Write(" ++");
        Console.WriteLine();
    }
}
