# LINQ機能

C#で`LINQ`（Language Integrated Query）を使用するサンプルプログラムを紹介します。`LINQ` は、データコレクションに対して簡潔で読みやすいクエリを書くための強力な機能です。この例では、リストの要素をフィルタリング、ソート、変換する基本的な操作を行います。

## サンプルプログラムの概要
- リスト内の特定の条件を満たす要素をフィルタリング。
- 結果を特定の基準でソート。
- 結果の各要素を新しい形式に変換。

## プログラムのコード
### Program.cs

```csharp
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExample
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Person> people = new List<Person>
			{
				new Person("Alice", 30),
				new Person("Bob", 25),
				new Person("Carol", 35),
				new Person("David", 28)
			};

			// 30歳以上の人を選択し、名前でソート
			var filteredSortedPeople = people
				.Where(p => p.Age >= 30)
				.OrderBy(p => p.Name)
				.Select(p => new { p.Name, p.Age });

			Console.WriteLine("People aged 30 or older:");
			foreach (var person in filteredSortedPeople)
			{
				Console.WriteLine($"{person.Name} is {person.Age} years old.");
			}
		}
	}

	class Person
	{
		public string Name { get; }
		public int Age { get; }

		public Person(string name, int age)
		{
			Name = name;
			Age = age;
		}
	}
}
```

## 実行手順
1. 上記の `Program.cs` を含む新しい .NET コンソールアプリケーションプロジェクトを作成します。
2. `Program.cs` をプロジェクトに追加します。
3. コマンドラインでプロジェクトディレクトリに移動し、`dotnet run` コマンドを実行してプログラムを起動します。

このプログラムでは、`Person` オブジェクトのリストから30歳以上の人々を選択し、名前でソートしています。`LINQ`クエリは、`Where` メソッドでフィルタリング、`OrderBy` メソッドでソート、そして `Select` メソッドで結果の形式を変換しています。`LINQ`はデータを操作する際に非常に強力で柔軟なツールです。
