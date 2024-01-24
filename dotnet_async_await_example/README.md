# Async/Await

C#の `async` と `await` キーワードを使用して、非同期プログラミングを行うサンプルプログラムを作成します。この例では、非同期メソッドを定義し、そのメソッドを非同期的に実行する方法を示します。

以下は、非同期プログラミングを実装するためのC#のサンプルコードです：

```csharp
using System;
using System.Threading.Tasks;

class Program
{
	static async Task Main(string[] args)
	{
		Console.WriteLine("非同期処理を開始します。");

		// 非同期メソッドの呼び出し
		await PerformLongRunningWork();

		Console.WriteLine("非同期処理が完了しました。");
	}

	static async Task PerformLongRunningWork()
	{
		Console.WriteLine("長時間実行する処理を開始します。");

		// 擬似的な長時間処理（ここでは3秒待機）
		await Task.Delay(3000);

		Console.WriteLine("長時間実行する処理が完了しました。");
	}
}
```

このプログラムでは、以下の操作を行います：

1. `Main` メソッドを非同期にするために `async` キーワードを使用し、`Task` を返します。
2. `PerformLongRunningWork` という非同期メソッドを定義します。このメソッド内で、`Task.Delay` を使って非同期に3秒待機します。
3. `Main` メソッドから `PerformLongRunningWork` メソッドを `await` キーワードを使って呼び出します。

`async` と `await` を使用することで、非同期プログラミングをシンプルに記述できます。このサンプルでは、長時間実行する処理を模擬的に `Task.Delay` を使って表現していますが、実際のアプリケーションではデータベースへの問い合わせ、ファイルの読み書き、ネットワーク操作など、様々な非同期操作に対応することができます。

このサンプルプログラムをコンパイルして実行すると、メインスレッドがブロックされることなく、非同期メソッドが実行されます。その結果、UIの応答性が維持されたり、サーバーアプリケーションのスケーラビリティが向上したりします。

