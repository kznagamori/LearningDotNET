using System;

namespace SimpleClassExample
{
	class Program
	{
		static void Main(string[] args)
		{
			// Person クラスのインスタンスを作成
			var person1 = new Person("Alice", 30);
			var person2 = new Person("Bob", 25);

			// インスタンスの情報を表示
			person1.DisplayInfo();
			person2.DisplayInfo();
		}
	}
}
