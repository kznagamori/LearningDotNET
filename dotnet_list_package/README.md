# リンクドリスト

C#でリンクドリスト（ `LinkedList` ）を使用したサンプルプログラムを提供します。このプログラムでは、`System.Collections.Generic` 名前空間の `LinkedList<T>` クラスを使用して、リンクドリストを作成し、要素を追加、削除、表示する基本的な操作を行います。

以下は、C#でのリンクドリストを使用した実行可能なサンプルコードです：

```csharp
using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		// LinkedListのインスタンスを作成
		LinkedList<string> linkedList = new LinkedList<string>();

		// 要素をリストの末尾に追加
		linkedList.AddLast("Item1");
		linkedList.AddLast("Item2");
		linkedList.AddLast("Item3");

		// リストの先頭に要素を追加
		linkedList.AddFirst("Item0");

		// リストの内容を表示
		Console.WriteLine("LinkedListの内容:");
		foreach (var item in linkedList)
		{
			Console.WriteLine(item);
		}

		// 特定の要素を削除
		linkedList.Remove("Item2");

		// 削除後のリストを表示
		Console.WriteLine("\nItem2を削除後のLinkedList:");
		foreach (var item in linkedList)
		{
			Console.WriteLine(item);
		}
	}
}
```
このプログラムでは以下の操作を行います：

1. LinkedList<T> のインスタンスを作成します。
2. AddLast メソッドを使用して、リンクドリストの末尾に要素を追加します。
3. AddFirst メソッドを使用して、リンクドリストの先頭に要素を追加します。
4. foreach ループを使用して、リンクドリストのすべての要素を表示します。
5. Remove メソッドを使用して、リストから特定の要素を削除します。
6. 再度、リンクドリストの内容を表示して、削除が反映されていることを確認します。

このサンプルプログラムをコンパイルして実行すると、リンクドリストの基本的な使い方を確認できます。
