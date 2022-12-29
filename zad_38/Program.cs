//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементами массива.

Console.WriteLine("Задайте размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Получили такой массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int a = 0; a < numbers.Length; a++)
{
    if (numbers[a] > max)
        {
            max = numbers[a];
        }
    if (numbers[a] < min)
        {
            min = numbers[a];
        }
}

Console.WriteLine($"Всего в массиве чисел  {numbers.Length} шт. Максимальное число = {max}, минимальное число = {min}");
Console.WriteLine($"Разность между максимальным и минимальным числами составляет {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.WriteLine();
}