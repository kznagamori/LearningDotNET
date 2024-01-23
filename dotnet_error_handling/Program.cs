using System;

namespace ErrorHandlingExample
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				var result = Calculator.Divide(10, 0);
				Console.WriteLine($"Result: {result}");
			}
			catch (DivideByZeroException ex)
			{
				Console.WriteLine($"An error occurred: {ex.Message}");
			}
		}
	}
}
