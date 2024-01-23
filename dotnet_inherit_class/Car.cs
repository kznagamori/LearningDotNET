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
