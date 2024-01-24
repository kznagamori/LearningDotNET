using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		// Dictionaryのインスタンスを作成
		Dictionary<string, string> dictionary = new Dictionary<string, string>();

		// 要素を追加
		dictionary.Add("key1", "value1");
		dictionary.Add("key2", "value2");
		dictionary.Add("key3", "value3");

		// 要素を表示
		Console.WriteLine("Dictionaryの内容:");
		foreach (KeyValuePair<string, string> item in dictionary)
		{
			Console.WriteLine($"キー: {item.Key}, 値: {item.Value}");
		}

		// 特定のキーに対する値の取得
		if (dictionary.TryGetValue("key2", out string? value))
		{
			Console.WriteLine("\nキー 'key2' の値: " + value);
		}
		else
		{
			Console.WriteLine("\nキー 'key2' は見つかりません。");
		}
	}
}
