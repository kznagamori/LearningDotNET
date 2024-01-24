# ハッシュテーブル

C#でハッシュテーブルを使用する場合、一般的には `System.Collections.Generic` 名前空間の `Dictionary<TKey, TValue>` クラスが使われます。これは、キーと値のペアを格納するためのコレクションであり、内部的にハッシュテーブルを使用しています。

以下は、C#で `Dictionary` を使用したハッシュテーブルの実装例です。このサンプルプログラムでは、いくつかのキーと値のペアを `Dictionary` に追加し、それらを順に表示します。

```csharp
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
```

このプログラムでは以下の操作を行います：

1. `Dictionary<string, string>` のインスタンスを作成します。
2. `Add` メソッドを使用して、キーと値のペアを追加します。
3. `foreach` ループを使用して、追加された要素を表示します。
4. `TryGetValue` メソッドを使用して、特定のキーに対応する値を取得し、表示します。
5. `Dictionary<TKey, TValue>` は、キーに対して高速なアクセスを提供し、キーと値のペアを効率的に格納および取得するためのデータ構造です。キーはユニークでなければなりませんが、値は重複しても構いません。

このサンプルプログラムをコンパイルして実行すると、C#でのハッシュテーブルの基本的な使い方を確認できます。
