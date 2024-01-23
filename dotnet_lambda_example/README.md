# ラムダ式

C#でラムダ式を使用するサンプルプログラムを紹介します。ラムダ式は、簡潔な方法でメソッドを定義し、特に`LINQ`やイベントハンドラなどの機能と組み合わせて使用されることが多いです。この例では、リストの要素に対してラムダ式を使って操作を行うシンプルなプログラムを作成します。

## サンプルプログラムの概要
- ラムダ式を使用してリストの各要素に操作を適用。
-  ラムダ式を使用してリスト内の特定の条件を満たす要素を検索。

## プログラムのコード
### Program.cs

```csharp
using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExample
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

			// リストの各要素を2倍にする
			List<int> doubledNumbers = numbers.Select(x => x * 2).ToList();
			Console.WriteLine("Doubled Numbers:");
			doubledNumbers.ForEach(n => Console.WriteLine(n));

			// リストから偶数を見つける
			List<int> evenNumbers = numbers.FindAll(x => x % 2 == 0);
			Console.WriteLine("\nEven Numbers:");
			evenNumbers.ForEach(n => Console.WriteLine(n));
		}
	}
}
```

## 実行手順
1. 上記の `Program.cs` を含む新しい .NET コンソールアプリケーションプロジェクトを作成します。
2. `Program.cs` をプロジェクトに追加します。
3. コマンドラインでプロジェクトディレクトリに移動し、`dotnet run` コマンドを実行してプログラムを起動します。

このプログラムでは、ラムダ式を使用してリストの各要素に操作を適用し（各要素を2倍にする）、リストから特定の条件（偶数である）を満たす要素を選択しています。ラムダ式は非常に強力で、コードをより読みやすく、簡潔にすることができます。
