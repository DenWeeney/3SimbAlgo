        // Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
		// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
		// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
		// лучше обойтись исключительно массивами.


		
string[] arr = {"Friend", "111", "world", "6555"};
		
		
int MaxLength = 3;
		
string[] GetShortWordsArray(string[] array)
	{
		int length = array.Length;			
		string[] result = new string[length];
		int count = 0;

		for (int i = 0; i < length; i++)
		{
			if(array[i].Length <= MaxLength)
			{
				result[count] = array[i];
				count++;
			}
		}
		
		
		return result;
	}
	
	void PrintArray(string[] array)
	{
		if(array.Length <1)
		{
			Console.WriteLine("-");
		}
		else
		{
			Array.ForEach(array, (str) => Console.Write($"{str} "));
			Console.WriteLine();
		}
		}
		
		void PrintTask(string[] array)
		{
		string[] shortArray = GetShortWordsArray(array);
		PrintArray(shortArray);
		Console.WriteLine();
	}
		
		PrintTask(arr);