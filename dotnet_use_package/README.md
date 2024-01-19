# 外部パッケージを使用したプログラムを作成する手順

.NET (C#) で外部パッケージを使用したプログラムを作成するには、以下の手順を踏みます。サンプルとして、人気のある外部パッケージ「 `Newtonsoft.Json` 」を使ってJSONデータを扱う簡単なプログラムを作成します。

## ステップ 1: .NET プロジェクトの作成
まず、.NET コンソールアプリケーションを作成します。コマンドライン（またはターミナル）を開き、以下のコマンドを実行します。

```bash
dotnet new console -o dotnet_use_package
cd dotnet_use_package
```

これで `dotnet_use_package` という名前の新しいプロジェクトが作成され、そのディレクトリに移動します。

## ステップ 2: 外部パッケージの追加
次に、`Newtonsoft.Json` パッケージをプロジェクトに追加します。これは、以下のコマンドを実行することで行えます。

```bash
dotnet add package Newtonsoft.Json
```

このコマンドは、プロジェクトに `Newtonsoft.Json` パッケージを追加し、依存関係をプロジェクトファイルに自動で記述します。

## ステップ 3: コードの編集
次に、`Program.cs` ファイルを編集して、JSONデータを扱うコードを書きます。以下はそのサンプルです。

```csharp
using System;
using Newtonsoft.Json;

namespace MyJsonApp
{
	class Program
	{
		static void Main(string[] args)
		{
			var person = new Person
			{
				Name = "Alice",
				Age = 30
			};

			string json = JsonConvert.SerializeObject(person);
			Console.WriteLine("Serialized JSON:");
			Console.WriteLine(json);

			var deserializedPerson = JsonConvert.DeserializeObject<Person>(json);
			Console.WriteLine("Deserialized JSON:");
			if (deserializedPerson != null)
			{
				Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
			}
		}
	}

	public class Person
	{
		public string? Name { get; set; }
		public int Age { get; set; }
	}
}
```

このコードでは、Person クラスのインスタンスを作成し、それをJSON形式にシリアライズしています。その後、シリアライズされたJSONを再び Person オブジェクトにデシリアライズしています。

### ステップ 4: プログラムの実行
最後に、以下のコマンドを使用してプログラムを実行します。

```bash
dotnet run
```
これにより、プログラムが実行され、JSONのシリアライズとデシリアライズの結果がコンソールに表示されます。

これらの手順に従って、.NET (C#) で外部パッケージを使用したプログラムを作成することができます。
