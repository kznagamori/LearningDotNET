using System;
using System.Collections.Concurrent;
using System.Threading;

class MessageBox
{
	private ConcurrentDictionary<int, (string Message, AutoResetEvent Event)> messageQueue = new ConcurrentDictionary<int, (string, AutoResetEvent)>();

	public void SendMessage(int recipientId, string message)
	{
		var autoEvent = new AutoResetEvent(false);
		messageQueue[recipientId] = (message, autoEvent);
		autoEvent.Set();
	}

	public bool ReceiveMessage(int recipientId, out string? message, int timeout)
	{
		message = null;
		if (messageQueue.TryRemove(recipientId, out var messageData))
		{
			message = messageData.Message;
			return messageData.Event.WaitOne(timeout);
		}
		return false;
	}
}

class Program
{
	static MessageBox messageBox = new MessageBox();

	static void Main()
	{
		Thread[] threads = new Thread[3];
		for (int i = 0; i < threads.Length; i++)
		{
			int threadId = i;
			threads[i] = new Thread(() => ThreadWork(threadId));
			threads[i].Start();
		}

		// 各スレッドにメッセージを送信
		for (int i = 0; i < threads.Length; i++)
		{
			messageBox.SendMessage(i, $"Message to thread {i}");
		}

		// すべてのスレッドの終了を待つ
		foreach (var thread in threads)
		{
			thread.Join();
		}

		Console.WriteLine("すべてのスレッドが終了しました。");
	}

	static void ThreadWork(int id)
	{
		Console.WriteLine($"スレッド {id} が起動しました。");

		if (messageBox.ReceiveMessage(id, out string? message, 10000)) // 10秒のタイムアウト
		{
			Console.WriteLine($"スレッド {id} はメッセージを受信しました: {message}");
		}
		else
		{
			Console.WriteLine($"スレッド {id} はタイムアウトしました。");
		}
	}
}
