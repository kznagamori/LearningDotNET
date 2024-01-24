using System;

class ShellSortExample
{
	static void ShellSort(int[] arr)
	{
		int n = arr.Length;

		for (int gap = n / 2; gap > 0; gap /= 2)
		{
			for (int i = gap; i < n; i += 1)
			{
				int temp = arr[i];
				int j;
				for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
				{
					arr[j] = arr[j - gap];
				}
				arr[j] = temp;
			}
		}
	}

	static void Main(string[] args)
	{
		int[] array = { 12, 34, 54, 2, 3 };
		Console.WriteLine("Original array: ");
		foreach (int value in array)
		{
			Console.Write(value + " ");
		}

		ShellSort(array);

		Console.WriteLine("\nSorted array: ");
		foreach (int value in array)
		{
			Console.Write(value + " ");
		}
	}
}
