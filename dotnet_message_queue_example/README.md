# メッセージキュー

C#でメッセージキューを使用した複数スレッド間でのデータ共有を実装するサンプルプログラムを作成します。このプログラムでは、メッセージキューの概念を独自に実装し、メインスレッドから子スレッドへのデータ送信と、子スレッドによるデータの受信を行います。

以下に、メッセージキューを使用した複数スレッド間のデータ共有を実現するC#のサンプルコードを示します：

```csharp
using System;
using System.Collections.Concurrent;
using System.Threading;

class MessageQueue<T>
{
	private ConcurrentQueue<T?> queue = new ConcurrentQueue<T?>();
	private AutoResetEvent queueNotifier = new AutoResetEvent(false);
	private const int MaxSize = 3;

	public bool Enqueue(T? item)
	{
		bool wasEmpty = queue.Count == 0;
		if (queue.Count < MaxSize)
		{
			queue.Enqueue(item);
			if (wasEmpty)
			{
				queueNotifier.Set();
			}
			return true;
		}
		return false;
	}

	public bool TryDequeue(out T? item, int timeout)
	{
		item = default(T);
		while (queue.Count == 0)
		{
			if (!queueNotifier.WaitOne(timeout))
			{
				return false;
			}
		}
		return queue.TryDequeue(out item);
	}
}

class Program
{
	static MessageQueue<string?> messageQueue = new MessageQueue<string?>();
	static int messageCount = 10;

	static void Main()
	{
		Thread[] threads = new Thread[3];
		for (int i = 0; i < threads.Length; i++)
		{
			threads[i] = new Thread(WorkerThread);
			threads[i].Start(i);
		}

		for (int i = 0; i < messageCount; i++)
		{
			while (!messageQueue.Enqueue($"Message {i + 1}"))
			{
				Thread.Sleep(500); // キューが満杯の場合は少し待つ
			}
		}

		// 子スレッドの終了を待つ
		foreach (var thread in threads)
		{
			thread.Join();
		}
		Console.WriteLine("すべてのスレッドが終了しました。");
	}

	static void WorkerThread(object? id)
	{
		Console.WriteLine($"スレッド {id} が起動しました。");

		while (true)
		{
			if (messageQueue.TryDequeue(out string? message, 10000)) // 10秒のタイムアウト
			{
				Console.WriteLine($"スレッド {id} がメッセージを受信しました: {message}");
			}
			else
			{
				Console.WriteLine($"スレッド {id} はタイムアウトしました。");
				break;
			}
		}
	}
}
```

このプログラムでは、次のような動作を行います：

1. `MessageQueue<T>` クラスを定義し、スレッド間のデータ送受信機能を実装します。
2. メッセージキューにデータを送信する `Enqueue` メソッドと、データを受信する `TryDequeue` メソッドを実装します。
3. メインスレッドで3つの子スレッドを起動し、それぞれがメッセージキューからデータを受信します。
4. メインスレッドはメッセージキューに合計10個のデータを送信します。キューが満杯の場合、メインスレッドは一時的に待機します。
5. 各子スレッドは、1秒ごとにメッセージキューからデータを受信し、10秒間データが受信されない場合に終了します。

メインスレッドはすべての子スレッドの終了を待ち合わせます。
このサンプルプログラムをコンパイルして実行すると、メインスレッドから各子スレッドへのメッセージの送信と、子スレッドによるメッセージの受信が行われ、プログラムが正常に終了します。
