// Задача 56: Задайте прямоугольный двумерный массив. 
//  Напишите программу, которая будет находить строку с наименьшей суммой элементов.



Console.WriteLine("Задайте количество строк");
int lines = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте  количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[lines, columns];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
Console.WriteLine();

int minsum = Int32.MaxValue;
int indexLine = 0;

for (int i = 0; i < numbers.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        sum = sum + numbers[i, j];        
    }
    if (sum < minsum)
    {
        minsum = sum;
        indexLine++;
    }
}

Console.WriteLine("Строка с минимальной суммой всех элементов имеет номер: " + (indexLine) + ", Сумма элементов этой строки равна: " + (minsum));

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
        Console.Write("** ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("**");
        Console.WriteLine();
    }
}
