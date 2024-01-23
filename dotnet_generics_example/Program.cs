using System;

namespace GenericExample
{
	class Program
	{
		static void Main(string[] args)
		{
			var intBox = new Box<int>(123);
			var stringBox = new Box<string>("Hello World");
			var doubleBox = new Box<double>(3.14);

			Utility.DisplayBoxContent(intBox);
			Utility.DisplayBoxContent(stringBox);
			Utility.DisplayBoxContent(doubleBox);
		}
	}
}
