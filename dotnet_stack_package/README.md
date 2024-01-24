# スタック構造

C#でスタック（ `Stack` ）を使用したサンプルプログラムを提供します。このプログラムでは、`System.Collections.Generic` 名前空間の `Stack<T>` クラスを使用して、スタックを作成し、要素を追加（プッシュ）、削除（ポップ）、表示する基本的な操作を行います。

以下は、C#でのスタックを使用した実行可能なサンプルコードです：

```csharp
using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		// Stackのインスタンスを作成
		Stack<string> stack = new Stack<string>();

		// スタックに要素を追加
		stack.Push("Item1");
		stack.Push("Item2");
		stack.Push("Item3");

		// スタックの内容を表示
		Console.WriteLine("Stackの内容:");
		foreach (var item in stack)
		{
			Console.WriteLine(item);
		}

		// スタックから要素を削除して表示
		Console.WriteLine("\nポップ操作:");
		while (stack.Count > 0)
		{
			string item = stack.Pop();
			Console.WriteLine("ポップしたアイテム: " + item);
		}

		// 最終的なスタックの状態を表示
		Console.WriteLine("\n最終的なStackのサイズ: " + stack.Count);
	}
}
```
このプログラムでは以下の操作を行います：

1. `Stack<T>` のインスタンスを作成します。
2. `Push` メソッドを使用して、スタックに要素を追加します。
3. `foreach` ループを使用して、スタックのすべての要素を表示します。
4. `Pop` メソッドを使用して、スタックから要素を一つずつ取り出し（削除し）、その内容を表示します。
5. スタックの最終的な状態（サイズ）を表示します。
このサンプルプログラムをコンパイルして実行すると、スタックの基本的な使い方を確認できます。スタックは後入れ先出し（ `LIFO` ）の特性を持つコレクションです。

