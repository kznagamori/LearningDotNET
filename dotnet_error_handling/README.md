# 一般的なエラー処理

C#で一般的なエラー処理を行う実行可能なサンプルプログラムを作成しましょう。この例では、関数から例外をスローし、呼び出し側でその例外をキャッチして処理する方法を示します。

## サンプルプログラムの概要
- Calculator.cs - 除算を行う簡単な関数を含むクラス。0による除算時に例外をスローします。
- Program.cs - `Calculator` クラスを使用し、例外をキャッチして処理するメインプログラム。

## Calculator クラスの定義
`Calculator` クラスでは、除算を行う簡単な関数を定義し、除数が0の場合に `DivideByZeroException` をスローします。

### Calculator.cs

```csharp
using System;

namespace ErrorHandlingExample
{
	public class Calculator
	{
		public static double Divide(int numerator, int denominator)
		{
			if (denominator == 0)
			{
				throw new DivideByZeroException("Denominator cannot be zero.");
			}

			return (double)numerator / denominator;
		}
	}
}
```

## メインプログラム（Program.cs）
メインプログラムでは、`Calculator.Divide` 関数を呼び出し、例外がスローされた場合にそれをキャッチして処理します。

### Program.cs

```csharp
using System;

namespace ErrorHandlingExample
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				var result = Calculator.Divide(10, 0);
				Console.WriteLine($"Result: {result}");
			}
			catch (DivideByZeroException ex)
			{
				Console.WriteLine($"An error occurred: {ex.Message}");
			}
		}
	}
}
```

## 実行手順
1. 上記の `Calculator.cs` と `Program.cs` を含む新しい .NET コンソールアプリケーションプロジェクトを作成します。
2. これらのファイルをプロジェクトに追加します。
3. コマンドラインでプロジェクトディレクトリに移動し、`dotnet run` コマンドを実行してプログラムを起動します。

このプログラムは、例外をスローし、それをキャッチして適切に処理する一般的な方法を示しています。`Calculator.Divide` 関数は、除数が0の場合に `DivideByZeroException` をスローし、メインプログラムの `try-catch` ブロックはこの例外をキャッチして、エラーメッセージをユーザーに表示します。これにより、プログラムが予期せぬ方法でクラッシュするのを防ぎます。
