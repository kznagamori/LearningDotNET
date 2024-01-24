using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		// SortedDictionaryのインスタンスを作成
		SortedDictionary<int, string> sortedDict = new SortedDictionary<int, string>();

		// 要素を追加
		sortedDict.Add(3, "Item3");
		sortedDict.Add(1, "Item1");
		sortedDict.Add(4, "Item4");
		sortedDict.Add(2, "Item2");

		// 要素をキーでソートして表示
		Console.WriteLine("SortedDictionaryの内容:");
		foreach (var kvp in sortedDict)
		{
			Console.WriteLine($"キー: {kvp.Key}, 値: {kvp.Value}");
		}
	}
}
