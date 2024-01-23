# ファイル内グローバル変数と関数、ファイル外グローバル変数と関数

C# では「グローバル変数」という概念は直接存在しませんが、静的クラスと静的メンバーを使って、グローバルにアクセス可能な変数や関数を実現することができます。ただし、ファイル内で定義された通常の変数や関数は、他のファイルから直接アクセスすることはできません。これを実現するために、サンプルプログラムを2つのファイルに分けて作成します。

## サンプルプログラムの概要
- `GlobalData.cs` - 静的クラスと静的メンバー（変数と関数）を含むファイル。これらは他のファイルからアクセス可能です。
- `Program.cs` - メインプログラムファイル。`GlobalData` クラスの静的メンバーにアクセスします。
### GlobalData.cs
このファイルには、静的な変数と関数を定義します。これらはアプリケーション全体でアクセス可能です。

```csharp
using System;

namespace GlobalExample
{
	public static class GlobalData
	{
		public static string GlobalVariable = "Initial Value";

		public static void DisplayGlobalVariable()
		{
			Console.WriteLine($"Global Variable: {GlobalVariable}");
		}

		public static void ModifyGlobalVariable(string newValue)
		{
			GlobalVariable = newValue;
		}
	}
}
```

### Program.cs
このファイルでは、`GlobalData` クラスの静的メンバーにアクセスします。また、ファイル内で定義された変数や関数にはアクセスできないことをコメントで示します。

```csharp
using System;
using GlobalExample;

namespace GlobalExample
{
	class Program
	{
		// この変数と関数はこのファイル内からのみアクセス可能です。
		private static string LocalVariable = "Local Value";

		private static void DisplayLocalVariable()
		{
			Console.WriteLine($"Local Variable: {LocalVariable}");
		}

		static void Main(string[] args)
		{
			// グローバル変数を表示
			GlobalData.DisplayGlobalVariable();

			// グローバル変数を変更
			GlobalData.ModifyGlobalVariable("New Value");

			// 変更後のグローバル変数を表示
			GlobalData.DisplayGlobalVariable();

			// ローカル変数の表示
			DisplayLocalVariable();

			// GlobalData.cs内のローカル変数や関数にはアクセスできない（以下はコメントアウト）
			// Console.WriteLine(GlobalData.LocalVariableInGlobalData);  // アクセス不可
			// GlobalData.DisplayLocalVariableInGlobalData();           // アクセス不可
		}
	}
}
```

## 実行手順
1. 上記のコードを `GlobalData.cs` と `Program.cs` という2つのファイルに分けて保存します。
2. .NET コンソールアプリケーションプロジェクト内でこれらのファイルを作成します。
3. `dotnet run` コマンドを使ってプログラムを実行します。

このサンプルでは、`GlobalData.cs` に定義された静的メンバーはプログラム全体からアクセス可能ですが、各ファイル内で定義された非静的メンバーにはそのファイル外からアクセスすることはできません。これにより、グローバル変数とローカル変数の違いを示しています。