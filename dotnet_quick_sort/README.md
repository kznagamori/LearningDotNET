# クイックソート

C#でクイックソートアルゴリズムを実装するためのサンプルプログラムを提供します。クイックソートは効率的な比較ソートアルゴリズムであり、分割統治法を用いて配列をソートします。基本的なアイデアは、配列から「ピボット」と呼ばれる要素を選び、ピボットより小さい要素を左に、ピボットより大きい要素を右に配置することです。

以下はクイックソートを実装する簡単な例です：

```csharp
using System;

class QuickSortExample
{
	static void QuickSort(int[] arr, int low, int high)
	{
		if (low < high)
		{
			int pivotIndex = Partition(arr, low, high);

			QuickSort(arr, low, pivotIndex - 1);
			QuickSort(arr, pivotIndex + 1, high);
		}
	}

	static int Partition(int[] arr, int low, int high)
	{
		int pivot = arr[high];
		int i = (low - 1);

		for (int j = low; j < high; j++)
		{
			if (arr[j] < pivot)
			{
				i++;
				Swap(ref arr[i], ref arr[j]);
			}
		}
		Swap(ref arr[i + 1], ref arr[high]);
		return i + 1;
	}

	static void Swap(ref int a, ref int b)
	{
		int temp = a;
		a = b;
		b = temp;
	}

	static void Main(string[] args)
	{
		int[] array = { 10, 7, 8, 9, 1, 5 };
		int n = array.Length;
		QuickSort(array, 0, n - 1);

		Console.WriteLine("Sorted array: ");
		foreach (int item in array)
		{
			Console.Write(item + " ");
		}
	}
}
```

このプログラムでは、`QuickSort` メソッドを使用して配列をソートします。このメソッドは再帰的に呼び出され、`Partition` メソッドを使用して配列をピボットに基づいて分割します。`Partition` メソッドはピボットより小さい要素を左側に、ピボットより大きい要素を右側に移動させます。`Swap` メソッドは配列の要素を交換するために使用されます。

プログラムを実行すると、指定された配列がクイックソートアルゴリズムを使用してソートされ、ソートされた配列が出力されます。

