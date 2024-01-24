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
