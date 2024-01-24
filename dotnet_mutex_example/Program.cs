using System;
using System.Threading;

class Program
{
	private static Mutex mutex = new Mutex();
	private static int counter = 0;

	static void Main()
	{
		Thread thread1 = new Thread(UpdateResource);
		thread1.Start();

		Thread thread2 = new Thread(UpdateResource);
		thread2.Start();

		thread1.Join();
		thread2.Join();

		Console.WriteLine("最終的なカウンターの値: " + counter);
	}

	static void UpdateResource()
	{
		for (int i = 0; i < 10000; i++)
		{
			try
			{
				mutex.WaitOne();   // ミューテックスの取得
				counter++;         // 共有リソースの更新
			}
			finally
			{
				mutex.ReleaseMutex(); // ミューテックスの解放
			}
		}
	}
}
