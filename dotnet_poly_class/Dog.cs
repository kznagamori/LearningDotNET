using System;

namespace PolymorphismExample
{
	public class Dog : ISpeakable
	{
		public void Speak()
		{
			Console.WriteLine("The dog barks.");
		}
	}
}
