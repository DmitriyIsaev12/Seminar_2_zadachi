//Задача 50: Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
//                1 4 7 2
//                5 9 2 3
//                8 4 2 4
//                17 -> такого числа в массиве нет

Console.WriteLine("Укажите номер строки");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Укажите  номер столбца");
int m = Convert.ToInt32(Console.ReadLine());
// Создаём двумерный массив
int [,] numbers = new int [7,7];

FillArrayRandomNumbers(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("В данном массиве такого элемента не существует");
}
else
{
    Console.WriteLine($" Элемент {n} строки и {m} столбца это число: {numbers[n-1,m-1]}");
}
PrintArray(numbers);
// Создаём метод заполнения массива
void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}
// Создаем метод печати массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " " + "|");
        }   
        Console.WriteLine(); 
    }
}
