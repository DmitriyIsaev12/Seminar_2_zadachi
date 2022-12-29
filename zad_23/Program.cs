	//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
	// 3 -> 1, 8, 27
	// 5 -> 1, 8, 27, 64, 125
	
	
	Console.Write("Введите число: ");
	int kub = Convert.ToInt32(Console.ReadLine());
	
	void Kub(int[] kub){
	int counter = 0;
	int length = kub.Length;
	while (counter < length){
	kub[counter] = Convert.ToInt32(Math.Pow(counter, 3));
	counter++;
	}
	}
	
	void PrintArray(int[] coll){
	int count = coll.Length;
	int index = 0;
	while(index < count){
	Console.Write(coll[index]+ " ");
	index++;
	}
	} 
	
	int[] array = new int[kub+1];
	Kub(array);
	PrintArray(array);




