# クラスの継承を実現する

C#でクラスの継承を実装する基本的なサンプルプログラムを紹介します。この例では、基底クラス `Vehicle` と、このクラスを継承する2つの派生クラス `Car` と `Bicycle` を作成します。

## 基底クラス（Vehicle）
基底クラス `Vehicle` は、全ての車両に共通するプロパティとメソッドを持ちます。

### Vehicle.cs

```csharp
using System;

namespace InheritanceExample
{
	public class Vehicle
	{
		public string Brand { get; protected set; }
		public int Wheels { get; protected set; }

		public Vehicle(string brand, int wheels)
		{
			Brand = brand;
			Wheels = wheels;
		}

		public virtual void DisplayInfo()
		{
			Console.WriteLine($"Brand: {Brand}, Wheels: {Wheels}");
		}
	}
}
```

## 派生クラス（Car と Bicycle）
`Car` と `Bicycle` クラスは、`Vehicle` クラスを継承し、追加のプロパティやメソッドを持ちます。

### Car.cs

```csharp
using System;

namespace InheritanceExample
{
	public class Car : Vehicle
	{
		public int Seats { get; private set; }

		public Car(string brand, int seats) : base(brand, 4) // 4 wheels for a car
		{
			Seats = seats;
		}

		public override void DisplayInfo()
		{
			base.DisplayInfo();
			Console.WriteLine($"Seats: {Seats}");
		}
	}
}
```

### Bicycle.cs

```csharp
using System;

namespace InheritanceExample
{
	public class Bicycle : Vehicle
	{
		public bool HasBasket { get; private set; }

		public Bicycle(string brand, bool hasBasket) : base(brand, 2) // 2 wheels for a bicycle
		{
			HasBasket = hasBasket;
		}

		public override void DisplayInfo()
		{
			base.DisplayInfo();
			Console.WriteLine($"Has Basket: {HasBasket}");
		}
	}
}
```

## メインプログラム（Program.cs）
`Program.cs` ファイルでは、これらのクラスをインスタンス化し、それぞれの情報を表示します。

### Program.cs

```csharp
using System;

namespace InheritanceExample
{
	class Program
	{
		static void Main(string[] args)
		{
			var car = new Car("Toyota", 5);
			var bicycle = new Bicycle("Giant", true);

			Console.WriteLine("Car Info:");
			car.DisplayInfo();

			Console.WriteLine("\nBicycle Info:");
			bicycle.DisplayInfo();
		}
	}
}
```

## 実行手順
1. 上記の `Vehicle.cs`、`Car.cs`、`Bicycle.cs`、および `Program.cs` を含む新しい .NET コンソールアプリケーションプロジェクトを作成します。
2. これらのファイルをプロジェクトに追加します。
3. コマンドラインでプロジェクトディレクトリに移動し、`dotnet run` コマンドを実行してプログラムを起動します。

このプログラムは、基底クラスのプロパティとメソッドを継承し、それに加えて独自のプロパティとメソッドを持つ派生クラスの作成方法を示しています。これにより、C# の継承の基本的な概念を理解することができます。
