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
