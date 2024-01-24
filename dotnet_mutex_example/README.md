# 排他処理

C#でミューテックス（ `Mutex` ）を使用して、複数のスレッド間での排他制御を行うサンプルプログラムを作成します。ミューテックスを使うことで、同時に一つのスレッドのみが特定のコードセクションへのアクセスを許可されるようになります。

以下は、ミューテックスを使用して排他処理を行うためのC#のサンプルコードです：

```csharp
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
```

このプログラムでは以下の操作を行います：

1. `Mutex` オブジェクトを静的フィールドとして作成します。
2. `UpdateResource` というメソッドを定義し、このメソッド内でミューテックスを使って排他制御を行います。
3. 2つのスレッドを起動し、それぞれが `UpdateResource` メソッドを実行します。
4. 各スレッドは `counter` 変数を10000回インクリメントしますが、この操作はミューテックスによって排他制御されます。
5. 両方のスレッドの終了を待ってから、最終的な `counter` の値を表示します。

このサンプルプログラムをコンパイルして実行すると、2つのスレッドが同時に `counter` 変数を更新しようとしますが、ミューテックスによって一度に一つのスレッドのみが更新を行うことができるため、`counter` の最終的な値は正しく20000になります。これにより、競合状態やデータの破損を防ぐことができます。
