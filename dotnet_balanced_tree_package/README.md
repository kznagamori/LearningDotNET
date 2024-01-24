# 平衡二分木

C#では、平衡二分木を直接実装する標準パッケージは提供されていませんが、平衡二分木の一種である赤黒木（ `Red-Black Tree` ）は `SortedDictionary` や `SortedSet` の内部実装として使用されています。これらのクラスを利用して、平衡二分木の特性を持つデータ構造を使用することができます。

ここでは、`SortedDictionary` を使用した簡単なサンプルプログラムを提供します。`SortedDictionary` はキーと値のペアを保持し、キーに基づいて自動的に並べ替えられます。プログラムでは、いくつかの要素を `SortedDictionary` に追加し、それらを順に表示します。

```csharp
using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		// SortedDictionaryのインスタンスを作成
		SortedDictionary<int, string> sortedDict = new SortedDictionary<int, string>();

		// 要素を追加
		sortedDict.Add(3, "Item3");
		sortedDict.Add(1, "Item1");
		sortedDict.Add(4, "Item4");
		sortedDict.Add(2, "Item2");

		// 要素をキーでソートして表示
		Console.WriteLine("SortedDictionaryの内容:");
		foreach (var kvp in sortedDict)
		{
			Console.WriteLine($"キー: {kvp.Key}, 値: {kvp.Value}");
		}
	}
}
```

このプログラムでは以下の操作を行います：

1. `SortedDictionary<int, string>` のインスタンスを作成します。
2. `Add` メソッドを使用して、キーと値のペアを追加します。
3. `foreach` ループを使用して、キーに基づいて自動的にソートされた要素を表示します。

`SortedDictionary` は内部で赤黒木を使用しており、キーの追加、検索、削除の操作が平均的に `O(log n)` の時間で行われます。これにより、大量のデータを効率的に管理することが可能になります。

このサンプルプログラムをコンパイルして実行すると、`SortedDictionary` を使用して平衡二分木のような動作を行うことができます。ただし、`SortedDictionary` の内部実装の詳細は公開されていないため、具体的な挙動は `.NET Framework` や `.NET Core` のバージョンによって異なる場合があります。
