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
