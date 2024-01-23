# 複数ファイルを機能ごとにパッケージを分けて使用する

.NET (C#) で複数のファイルを機能ごとにパッケージ化し、別のプロジェクトから呼び出すサンプルプログラムを作成するには、以下の手順に従います。

## サンプルプログラムの概要
- LibraryProject - ライブラリとして機能するプロジェクト。Person クラスと Greeter サービスを含む。
- ConsoleAppProject - ライブラリを使用するコンソールアプリケーションプロジェクト。

### ステップ 1: ライブラリプロジェクトの作成
まず、ライブラリとして機能するプロジェクトを作成します。

1. コマンドラインで以下のコマンドを実行して、クラスライブラリプロジェクトを作成します。

```bash
dotnet new classlib -o LibraryProject
cd LibraryProject
```

### ステップ 2: ライブラリプロジェクトのコード編集
各ファイルに以下のコードを追加します。

#### Person.cs

```csharp
namespace LibraryProject
{
	public class Person
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

#### Greeter.cs

```csharp
namespace LibraryProject
{
	public static class Greeter
	{
		public static string Greet(Person person)
		{
			return $"Hello, {person.Name}! You are {person.Age} years old.";
		}
	}
}
```

### ステップ 3: コンソールアプリケーションプロジェクトの作成
1. ライブラリプロジェクトのディレクトリから戻り、新しいコンソールアプリケーションプロジェクトを作成します。

```bash
cd ..
dotnet new console -o ConsoleAppProject
cd ConsoleAppProject
```

2. コンソールアプリケーションプロジェクトにライブラリプロジェクトを参照として追加します。

```bash
dotnet add reference ../LibraryProject/LibraryProject.csproj
```

### ステップ 4: コンソールアプリケーションのコード編集
1. Program.cs に以下のコードを追加します。

```csharp
using System;
using LibraryProject;

namespace ConsoleAppProject
{
	class Program
	{
		static void Main(string[] args)
		{
			var person = new Person("Alice", 30);
			var message = Greeter.Greet(person);
			Console.WriteLine(message);
		}
	}
}
```

### ステップ 5: プログラムの実行
1. コンソールアプリケーションプロジェクトで以下のコマンドを実行します。

```bash
dotnet run
```

## .csprojファイルについて
.csprojファイルは、プロジェクトの構成情報を記述するXMLファイルです。上記の手順で作成されるプロジェクトの.csprojファイルは、デフォルトの設定で十分です。ただし、ライブラリプロジェクトへの参照を追加する部分は、コンソールアプリケーションの.csprojファイルに自動的に追加されます。これは以下のような行です。

**ConsoleAppProject.csproj**

```xml
<ItemGroup>
  <ProjectReference Include="..\LibraryProject\LibraryProject.csproj" />
</ItemGroup>
```

これらの手順に従うことで、機能ごとに異なるプロジェクトおよびディレクトリにコードを分け、ライブラリを別のプロジェクトから利用することができます。
