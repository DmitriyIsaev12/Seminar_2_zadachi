//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 


int [] numbers = new int[8];

for (int index = 0; index < numbers.Length; index++)
 {
    numbers [index] = new Random().Next(0, 11);
    Console.Write(" " + Method (index) + " ");
 }
int Method (int a)
{
    return numbers[a];
}