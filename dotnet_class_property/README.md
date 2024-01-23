# クラスのプロパティを定義、使用
C#でクラスのプロパティを定義し、それを使用する簡単なサンプルプログラムを作成しましょう。この例では、`Person` クラスに名前（ `Name` ）と年齢（ `Age` ）のプロパティを持たせ、これらのプロパティをメインプログラムで使用します。

## Person クラスの定義
`Person` クラスには、`Name` と `Age` の2つのプロパティを定義します。これらのプロパティには、ゲッター（読み取り）とセッター（書き込み）を設定します。

### Person.cs

``` csharp
namespace PropertiesExample
{
	public class Person
	{
		private string? name;
		private int age;

		public string? Name
		{
			get { return name; }
			set { name = value; }
		}

		public int Age
		{
			get { return age; }
			set { age = value; }
		}

		public Person(string? name, int age)
		{
			Name = name;
			Age = age;
		}
	}
}
```

## メインプログラム（Program.cs）
`Program.cs` では、`Person` クラスのインスタンスを作成し、そのプロパティにアクセスして値を設定および取得します。

### Program.cs

```csharp
using System;

namespace PropertiesExample
{
	class Program
	{
		static void Main(string[] args)
		{
			var person = new Person("Alice", 30);

			// プロパティの値を取得
			Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");

			// プロパティの値を設定
			person.Name = "Bob";
			person.Age = 25;

			// 新しいプロパティの値を取得
			Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
		}
	}
}
```

## 実行手順
1. 上記の `Person.cs` と `Program.cs` を含む新しい .NET コンソールアプリケーションプロジェクトを作成します。
2. これらのファイルをプロジェクトに追加します。
3. コマンドラインでプロジェクトディレクトリに移動し、`dotnet run` コマンドを実行してプログラムを起動します。

このプログラムは、C# でのプロパティの基本的な使用法を示しています。`Person` クラスは `Name` と `Age` のプロパティを持ち、これらのプロパティは外部からアクセス可能です。プロパティは、内部のフィールドの値をカプセル化し、外部から安全にアクセスできるようにするために使用されます。
