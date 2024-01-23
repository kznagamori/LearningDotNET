# プロジェクト作成からビルドまでの手順

C#でコマンドラインプログラムを作成し、ビルドするための手順は以下の通りです。

## 環境
.NET SDKがインストールされている必要があります。これは、Microsoftの公式サイトからダウンロードできます。

## プロジェクトの作成
1. コマンドラインを開く: コマンドプロンプトやターミナルを開きます。
プロジェクトディレクトリの作成: プロジェクトを格納するディレクトリを作成します。
```bash
dotnet new console -n dotnet_start_project
```
2. ディレクトリに移動:
```
cd dotnet_start_project
```

## プログラムの編集
作成された `Program.cs` ファイルをエディタで開き、プログラムを編集します。

### ビルドと実行
1. ビルド: プロジェクトディレクトリで `dotnet build` コマンドを実行してプロジェクトをビルドします。
2. 実行: `dotnet run` コマンドを実行してプログラムを実行します。

## サンプルプログラム
以下は簡単な「Hello, World!」プログラムの例です。

```csharp
using System;

namespace MyConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
		}
	}
}
```
このプログラムは、コンソールに「Hello, World!」と出力します。

これらの手順に従って、基本的なC#のコマンドラインプログラムを作成、編集、ビルド、実行することができます。