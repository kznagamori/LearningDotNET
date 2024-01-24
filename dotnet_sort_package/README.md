# ソート

C# でソート機能を使用する場合、標準ライブラリの `System.Linq` 名前空間にある `OrderBy` 、`OrderByDescending` メソッドなどがよく使われます。これらは、コレクションを特定の基準に従ってソートするためのメソッドです。また、`Array.Sort` メソッドや `List<T>.Sort` メソッドも利用できます。

ここでは、`List<T>` コレクションの要素を `Sort` メソッドを使用してソートする簡単なサンプルプログラムを示します。

```csharp
using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		// Listのインスタンスを作成し、要素を追加
		List<int> numbers = new List<int> { 5, 3, 8, 1, 2, 7 };

		// 要素をソート
		numbers.Sort();

		// ソートされた要素を表示
		Console.WriteLine("ソート後のリスト:");
		foreach (var number in numbers)
		{
			Console.WriteLine(number);
		}

		// 文字列リストの例
		List<string> strings = new List<string> { "Banana", "Apple", "Cherry" };

		// 文字列を辞書順でソート
		strings.Sort();

		// ソートされた文字列を表示
		Console.WriteLine("\nソート後の文字列リスト:");
		foreach (var str in strings)
		{
			Console.WriteLine(str);
		}
	}
}
```

このプログラムでは以下の操作を行います：

1. `int` 型の `List` を作成し、いくつかの数値を追加します。
2. `Sort` メソッドを使ってリストを昇順にソートします。
3. ソートされたリストの要素を順に表示します。
4. 同様に、`string` 型のリストに対してもソートを行い、結果を表示します。

`Sort` メソッドは、リストの各要素をデフォルトの比較演算子（数値の場合は数値順、文字列の場合は辞書順）を使用してソートします。カスタムの比較ロジックを使用する場合は、`Sort` メソッドに比較ロジックを提供することも可能です。

このサンプルプログラムをコンパイルして実行すると、リストの要素をソートする基本的な方法を確認できます。
