# クラスのインタフェースを使用したポリモーフィズムの実現

C#でインターフェースを使用してポリモーフィズムを実現する基本的なサンプルプログラムを作成しましょう。この例では、`ISpeakable` というインターフェースを定義し、異なる動物クラス（ `Dog` と `Cat` ）で実装します。

## インターフェースの定義（`ISpeakable`）
`ISpeakable` インターフェースには、`Speak` メソッドのシグネチャを定義します。

### ISpeakable.cs

```csharp
namespace PolymorphismExample
{
    public interface ISpeakable
    {
        void Speak();
    }
}
```

## 動物クラス（ `Dog` と `Cat` ）
`Dog` と `Cat` クラスは `ISpeakable` インターフェースを実装し、`Speak` メソッドを具体化します。

### Dog.cs

```csharp
using System;

namespace PolymorphismExample
{
    public class Dog : ISpeakable
    {
        public void Speak()
        {
            Console.WriteLine("The dog barks.");
        }
    }
}
```

### Cat.cs

```csharp
using System;

namespace PolymorphismExample
{
    public class Cat : ISpeakable
    {
        public void Speak()
        {
            Console.WriteLine("The cat meows.");
        }
    }
}
```

## メインプログラム（Program.cs）
`Program.cs` で `ISpeakable` インターフェース型の変数を使用して、`Dog` と `Cat` オブジェクトの `Speak` メソッドを呼び出します。

### Program.cs

```csharp
using System;
using System.Collections.Generic;

namespace PolymorphismExample
{
	class Program
	{
		static void Main(string[] args)
		{
			List<ISpeakable> animals = new List<ISpeakable>
			{
				new Dog(),
				new Cat()
			};

			foreach (var animal in animals)
			{
				animal.Speak();
			}
		}
	}
}
```

## 実行手順
1. 上記の `ISpeakable.cs`、`Dog.cs`、`Cat.cs` および `Program.cs` を含む新しい .NET コンソールアプリケーションプロジェクトを作成します。
2. これらのファイルをプロジェクトに追加します。
3. コマンドラインでプロジェクトディレクトリに移動し、`dotnet run` コマンドを実行してプログラムを起動します。

このプログラムは、インターフェースを使用したポリモーフィズムの基本を示しています。`ISpeakable` インターフェースを実装する `Dog` と `Cat` クラスは、同じインターフェースを共有しながら、`Speak` メソッドの異なる実装を持っています。これにより、異なる型のオブジェクトを同じ方法で操作することが可能になります。
