# シェルソート

C#で再帰を使用せずにシェルソートを実装するサンプルプログラムを提供します。シェルソートは、挿入ソートの一般化であり、より遠くにある要素間での比較と交換を行いながら、段階的に要素を整列させます。

以下はシェルソートを実装する簡単な例です：

```csharp
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
```

このプログラムでは、`ShellSort` メソッドを使用して配列をソートします。このメソッドでは、まずギャップの値を配列の長さの半分とし、その後、ギャップの値を段階的に半分に減らしながら、各ギャップについて挿入ソートを行います。これにより、初期のステップでは遠く離れた要素間で比較と交換が行われ、徐々に近い要素間での整列が行われるため、効率的なソートが可能になります。

プログラムを実行すると、指定された配列がシェルソートアルゴリズムを使用してソートされ、ソートされた配列が出力されます。
