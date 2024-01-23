using System;

namespace PropertiesExample
{
	class Program
	{
		static void Main(string[] args)
		{
			var person = new Person("Alice", 30);

			// プロパティの値を取得
			Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");

			// プロパティの値を設定
			person.Name = "Bob";
			person.Age = 25;

			// 新しいプロパティの値を取得
			Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
		}
	}
}
