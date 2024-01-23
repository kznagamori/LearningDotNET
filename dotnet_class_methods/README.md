# クラスを使う

.NET (C#) でクラスを使用する基本的なサンプルプログラムを作成しましょう。この例では、簡単な `Person` クラスを定義し、それをメインプログラムでインスタンス化して使用します。

## クラスの定義
まず、`Person` クラスを定義します。このクラスには名前 ( `Name` ) と年齢 ( `Age` ) の2つのプロパティがあります。また、コンストラクタを定義して、オブジェクトを初期化します。

### Person.cs

```csharp
using System;

namespace SimpleClassExample
{
	public class Person
	{
		public string Name { get; set; }
		public int Age { get; set; }

		public Person(string name, int age)
		{
			Name = name;
			Age = age;
		}

		public void DisplayInfo()
		{
			Console.WriteLine($"Name: {Name}, Age: {Age}");
		}
	}
}
```

## メインプログラム
次に、`Program.cs` ファイルを作成し、`Person` クラスのインスタンスを作成して使用します。

### Program.cs

``` csharp
using System;

namespace SimpleClassExample
{
	class Program
	{
		static void Main(string[] args)
		{
			// Person クラスのインスタンスを作成
			var person1 = new Person("Alice", 30);
			var person2 = new Person("Bob", 25);

			// インスタンスの情報を表示
			person1.DisplayInfo();
			person2.DisplayInfo();
		}
	}
}
```

## 実行手順
1. 上記の `Person.cs` と `Program.cs` を含む新しい .NET コンソールアプリケーションプロジェクトを作成します。
2. 両方のファイルをプロジェクトに追加します。
3. コマンドラインでプロジェクトディレクトリに移動し、`dotnet run` コマンドを実行してプログラムを起動します。

このプログラムでは、`Person` クラスが定義され、そのクラスを使って2つの異なる `Person` オブジェクトが作成されます。それぞれのオブジェクトは、`DisplayInfo` メソッドを使用して情報をコンソールに表示します。これは、C# でクラスを使ってオブジェクト指向プログラミングの基本を学ぶのに良い例です。
