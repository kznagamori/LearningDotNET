using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExample
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

			// リストの各要素を2倍にする
			List<int> doubledNumbers = numbers.Select(x => x * 2).ToList();
			Console.WriteLine("Doubled Numbers:");
			doubledNumbers.ForEach(n => Console.WriteLine(n));

			// リストから偶数を見つける
			List<int> evenNumbers = numbers.FindAll(x => x % 2 == 0);
			Console.WriteLine("\nEven Numbers:");
			evenNumbers.ForEach(n => Console.WriteLine(n));
		}
	}
}
