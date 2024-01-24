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
