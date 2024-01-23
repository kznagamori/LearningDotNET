# ジェネリック機能

C#でジェネリック（テンプレート）クラスやメソッドを定義し、それを使用するサンプルプログラムを作成しましょう。この例では、ジェネリックな `Box<T>` クラスと、ジェネリックメソッド `DisplayBoxContent` を作成します。

## ジェネリッククラスの定義（Box<T>）
`Box<T>` クラスは任意の型 `T` のアイテムを格納できるシンプルなコンテナです。

### Box.cs

```csharp
namespace GenericExample
{
	public class Box<T>
	{
		public T Content { get; set; }

		public Box(T content)
		{
			Content = content;
		}
	}
}
```

## ジェネリックメソッドの定義（DisplayBoxContent）
`DisplayBoxContent` メソッドは、`Box<T>` の内容を表示します。

### Utility.cs

```csharp
using System;

namespace GenericExample
{
	public static class Utility
	{
		public static void DisplayBoxContent<T>(Box<T> box)
		{
			Console.WriteLine($"Box contains: {box.Content}");
		}
	}
}
```

## メインプログラム（Program.cs）
メインプログラムでは、異なる型の `Box<T>` オブジェクトを作成し、`DisplayBoxContent` メソッドで内容を表示します。

### Program.cs

```csharp
using System;

namespace GenericExample
{
	class Program
	{
		static void Main(string[] args)
		{
			var intBox = new Box<int>(123);
			var stringBox = new Box<string>("Hello World");
			var doubleBox = new Box<double>(3.14);

			Utility.DisplayBoxContent(intBox);
			Utility.DisplayBoxContent(stringBox);
			Utility.DisplayBoxContent(doubleBox);
		}
	}
}
```

## 実行手順
1. 上記の `Box.cs`、`Utility.cs` および `Program.cs` を含む新しい .NET コンソールアプリケーションプロジェクトを作成します。
2. これらのファイルをプロジェクトに追加します。
3. コマンドラインでプロジェクトディレクトリに移動し、`dotnet run` コマンドを実行してプログラムを起動します。

このプログラムは、ジェネリッククラスとジェネリックメソッドの基本を示しています。ジェネリックを使用することで、さまざまな型に適用可能な再利用可能なコンポーネントを作成することができます。
