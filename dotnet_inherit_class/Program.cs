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
