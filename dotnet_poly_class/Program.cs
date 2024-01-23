using System;
using System.Collections.Generic;

namespace PolymorphismExample
{
	class Program
	{
		static void Main(string[] args)
		{
			List<ISpeakable> animals = new List<ISpeakable>
			{
				new Dog(),
				new Cat()
			};

			foreach (var animal in animals)
			{
				animal.Speak();
			}
		}
	}
}
