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
