# スレッド

C#で複数のスレッドを起動し、それらの終了を待つサンプルプログラムを作成します。この例では、`System.Threading` 名前空間の `Thread` クラスを使用します。プログラムでは、複数のスレッドで実行するための関数を定義し、それらのスレッドを起動した後、`Join` メソッドを使用してすべてのスレッドの完了を待ちます。

以下は、C#でのスレッドを使用したサンプルコードです：

```csharp
using System;
using System.Threading;

class Program
{
	static void Main()
	{
		// スレッドを起動する
		Thread thread1 = new Thread(new ThreadStart(ThreadFunction));
		thread1.Start();

		Thread thread2 = new Thread(new ThreadStart(ThreadFunction));
		thread2.Start();

		Thread thread3 = new Thread(new ThreadStart(ThreadFunction));
		thread3.Start();

		// 起動したスレッドの終了を待つ
		thread1.Join();
		thread2.Join();
		thread3.Join();

		Console.WriteLine("すべてのスレッドが終了しました。");
	}

	static void ThreadFunction()
	{
		for (int i = 0; i < 5; i++)
		{
			Console.WriteLine($"スレッドID: {Thread.CurrentThread.ManagedThreadId} - {i}");
			Thread.Sleep(1000); // 1秒間スリープ
		}
	}
}
```

このプログラムでは、以下の操作を行います：

1. `ThreadFunction` という名前の静的メソッドを定義します。このメソッドは、スレッドで実行するための関数です。
2. `Thread` クラスのインスタンスを作成し、`ThreadFunction` メソッドをスレッドで実行します。
3. 3つのスレッドを起動します。
4. `Join` メソッドを使用して、各スレッドの終了を待ちます。

このサンプルプログラムをコンパイルして実行すると、3つのスレッドが同時に動作し、それぞれが `ThreadFunction` メソッドを実行します。各スレッドは5回のループを行い、その間1秒ごとに現在のスレッドIDとループのカウンターを出力します。すべてのスレッドが終了すると、メインスレッドが「すべてのスレッドが終了しました」と出力します。
