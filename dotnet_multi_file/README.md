# 複数ファイルを使用する

.NET (C#) で複数ファイルを使用したサンプルプログラムを作成する場合、一般的なアプローチは、異なるクラスや機能を別々のファイルに分割することです。以下に、シンプルな例を示します。

## サンプルプログラムの概要
- `Program.cs` - メインエントリポイントを含むファイル。
- `Greeter.cs` - Greeter クラスを含むファイル。このクラスは挨拶メッセージを生成します。
- `Person.cs` - Person クラスを含むファイル。このクラスは人の情報を表します。

## ステップ 1: プロジェクトの作成
コマンドラインで以下のコマンドを実行して、新しいコンソールアプリケーションプロジェクトを作成します。

```bash
dotnet new console -o dotnet_multi_file
cd dotnet_multi_file
```

## ステップ 2: ファイルの追加
プロジェクトに2つの新しいファイル Greeter.cs と Person.cs を追加します。

## ステップ 3: コードの編集
各ファイルに以下のコードを追加します。

### Program.cs

```csharp
using System;

namespace MultiFileApp
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

### Person.cs

```csharp
namespace MultiFileApp
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

### Greeter.cs

```csharp
namespace MultiFileApp
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

## ステップ 4: プログラムの実行
コマンドラインで以下のコマンドを実行して、アプリケーションを実行します。

```bash
dotnet run
```

このサンプルプログラムでは、`Program.cs` がメインエントリポイントであり、`Person` と `Greeter` クラスを別々のファイルに分けています。`Program.cs` では `Person` インスタンスを作成し、`Greeter` クラスを使用して挨拶メッセージを生成しています。これは、複数ファイルを使用してクラスと機能を整理する一般的な方法です。
