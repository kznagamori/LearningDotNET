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
