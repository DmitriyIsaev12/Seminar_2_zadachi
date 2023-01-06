//Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.



void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5); //Здесь последнее число 5 можно увеличить для увеличения размера чисел в матрицах
        
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

int sizematrix = InputInt("Задайте размер матриц: ");
int[,] matrixA = new int[sizematrix, sizematrix];
int[,] matrixB = new int[sizematrix, sizematrix];
FillArrayRandomNumbers(matrixA);
FillArrayRandomNumbers(matrixB);
int[,] matrixC = new int[sizematrix, sizematrix];

for (int i = 0; i < sizematrix; i++)
{
    for (int j = 0; j < sizematrix; j++)
    {
        for (int k = 0; k < sizematrix; k++)
        {
            matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
        }
    }
}
Console.WriteLine("Матрица - А");
PrintArray(matrixA);
Console.WriteLine();
Console.WriteLine("Матрица - В");
PrintArray(matrixB);
Console.WriteLine();
Console.WriteLine("Перемноженные матрицы А*В");
PrintArray(matrixC);

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}