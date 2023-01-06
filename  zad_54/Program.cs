// Задача 54: Задайте двумерный массив. Напишите программу, 
//  которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("Задайте количество строк");
int lines = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте  количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] num = new int[lines, columns];
FillArrayRandomNumbers(num);
Console.WriteLine();
Console.WriteLine("Начальный массив");
PrintArray(num);

for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < num.GetLength(1) - 1; z++)
        {
            if (num[i, z] < num[i, z + 1]) // Меняем знак < на противоположный для изменения сортировки
            {
                int temp = 0;             // Меняем местами элементы массива 
                temp = num[i, z];
                num[i, z] = num[i, z + 1];
                num[i, z + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями");
PrintArray(num);

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
            Console.Write(array[i, j] + " ");
        }
        Console.Write("++");
        Console.WriteLine();
    }
}
