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
