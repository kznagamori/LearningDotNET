using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		// Listのインスタンスを作成し、要素を追加
		List<int> numbers = new List<int> { 5, 3, 8, 1, 2, 7 };

		// 要素をソート
		numbers.Sort();

		// ソートされた要素を表示
		Console.WriteLine("ソート後のリスト:");
		foreach (var number in numbers)
		{
			Console.WriteLine(number);
		}

		// 文字列リストの例
		List<string> strings = new List<string> { "Banana", "Apple", "Cherry" };

		// 文字列を辞書順でソート
		strings.Sort();

		// ソートされた文字列を表示
		Console.WriteLine("\nソート後の文字列リスト:");
		foreach (var str in strings)
		{
			Console.WriteLine(str);
		}
	}
}
