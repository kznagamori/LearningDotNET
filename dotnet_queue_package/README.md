# キュー構造

C# でキュー（ `Queue` ）を使用したサンプルプログラムを提供します。このプログラムでは、`System.Collections.Generic` 名前空間の `Queue<T>` クラスを使用して、キューを作成し、要素を追加（エンキュー）、削除（デキュー）、表示する基本的な操作を行います。

以下は、C#でのキューを使用した実行可能なサンプルコードです：

```csharp
using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		// Queueのインスタンスを作成
		Queue<string> queue = new Queue<string>();

		// キューに要素を追加
		queue.Enqueue("Item1");
		queue.Enqueue("Item2");
		queue.Enqueue("Item3");

		// キューの内容を表示
		Console.WriteLine("Queueの内容:");
		foreach (var item in queue)
		{
			Console.WriteLine(item);
		}

		// キューから要素を削除して表示
		Console.WriteLine("\nデキュー操作:");
		while (queue.Count > 0)
		{
			string item = queue.Dequeue();
			Console.WriteLine("デキューしたアイテム: " + item);
		}

		// 最終的なキューの状態を表示
		Console.WriteLine("\n最終的なQueueのサイズ: " + queue.Count);
	}
}
```

このプログラムでは以下の操作を行います：

1. `Queue<T>` のインスタンスを作成します。
2. `Enqueue` メソッドを使用して、キューに要素を追加します。
3. `foreach` ループを使用して、キューのすべての要素を表示します。
4. `Dequeue` メソッドを使用して、キューから要素を一つずつ取り出し（削除し）、その内容を表示します。
5. キューの最終的な状態（サイズ）を表示します。

このサンプルプログラムをコンパイルして実行すると、キューの基本的な使い方を確認できます。キューは先入れ先出し（ `FIFO` ）の特性を持つコレクションです。
