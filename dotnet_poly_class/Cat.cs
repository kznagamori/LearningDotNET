using System;

namespace PolymorphismExample
{
	public class Cat : ISpeakable
	{
		public void Speak()
		{
			Console.WriteLine("The cat meows.");
		}
	}
}
