using System;

namespace GenericExample
{
	public static class Utility
	{
		public static void DisplayBoxContent<T>(Box<T> box)
		{
			Console.WriteLine($"Box contains: {box.Content}");
		}
	}
}
