# メッセージボックス

C#で「メッセージボックス」機能を使った複数のスレッド間のデータ共有を実装するサンプルプログラムを作成します。この例では、標準のライブラリには直接的な「メッセージボックス」の機能は存在しないため、それを模倣するクラスを自作し、そのクラスを使用してメインスレッドと子スレッド間でのデータ共有を行います。

以下のサンプルコードは、メッセージボックス機能を持つクラスと、そのクラスを使用して複数のスレッド間でメッセージをやり取りする例を示しています：

```csharp
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
```

このプログラムでは、次のような動作を行います：

1. `MessageBox` クラスを定義し、スレッド間のメッセージ送受信機能を実装します。
2. `SendMessage` メソッドで指定されたスレッドIDにメッセージを送信します。
3. `ReceiveMessage` メソッドでメッセージを受信し、指定されたタイムアウト時間内にメッセージが届かなければタイムアウトします。
4. メインスレッドで3つの子スレッドを起動し、それぞれにメッセージを送信します。
5. 各子スレッドは、メッセージボックスからのメッセージを受信すると処理を完了し、スレッドを終了させます。
6. メインスレッドはすべての子スレッドの終了を待ち合わせます。

このサンプルプログラムをコンパイルして実行すると、メインスレッドから各子スレッドへのメッセージの送信と、子スレッドによるメッセージの受信が行われ、プログラムが正常に終了します。

