# パブリックなクラスのメンバ、メソッドを定義とプライベートなクラスのメンバ、メソッドを定義する

.NET (C#) で公開（パブリック）クラスや構造体のメンバとメソッド、および非公開（プライベート）クラスや構造体のメンバとメソッドを定義するサンプルプログラムを作成しましょう。この例では、パブリックな `Person` クラスと、プライベートな `SecretIdentity` クラスを使います。

## パブリッククラスとそのメンバー
まず、パブリックな `Person` クラスを定義します。このクラスには、パブリックなプロパティとメソッドが含まれます。

### Person.cs

```csharp
using System;

using System;

namespace PublicPrivateExample
{
	public class Person
	{
		public string Name { get; private set; }
		public int Age { get; private set; }

		private SecretIdentity secretIdentity;

		class SecretIdentity
		{
			private string SecretName;

			public SecretIdentity(string secretName)
			{
				SecretName = secretName;
			}

			public void DisplaySecret()
			{
				Console.WriteLine($"Secret Identity: {SecretName}");
			}
		}

		public Person(string name, int age, string secretName)
		{
			Name = name;
			Age = age;
			secretIdentity = new SecretIdentity(secretName);
		}

		public void DisplayPublicInfo()
		{
			Console.WriteLine($"Name: {Name}, Age: {Age}");
			secretIdentity.DisplaySecret();
		}
	}
}
```

## メインプログラム
次に、`Program.cs` ファイルを作成し、`Person` クラスのインスタンスを作成して、公開情報と非公開情報を表示します。

### Program.cs

```csharp
using System;
using PublicPrivateExample;

namespace PublicPrivateExample
{
	class Program
	{
		static void Main(string[] args)
		{
			var person = new Person("Alice", 30, "SuperAlice");
			person.DisplayPublicInfo();

			// 以下のコードはコンパイルエラーになります
			// Console.WriteLine(person.secretIdentity.SecretName); // 秘密のアイデンティティへの直接アクセスは許可されていません
		}
	}
}
```

## 実行手順
1. 上記の `Person.cs` と `Program.cs` を含む新しい .NET コンソールアプリケーションプロジェクトを作成します。
2. 両方のファイルをプロジェクトに追加します。
3. コマンドラインでプロジェクトディレクトリに移動し、`dotnet run` コマンドを実行してプログラムを起動します。

このプログラムでは、`Person` クラスが公開されており、外部からアクセスできます。内部にはプライベートな `SecretIdentity` クラスが含まれており、これは `Person` クラスの外部からは直接アクセスできません。`Person` クラスは、パブリックメソッドを通じて自身の公開情報と非公開情報を表示します。これにより、オブジェクト指向プログラミングのカプセル化の概念を示しています。
