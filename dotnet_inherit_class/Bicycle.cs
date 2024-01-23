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
