using System;

namespace ErrorHandlingExample
{
	public class Calculator
	{
		public static double Divide(int numerator, int denominator)
		{
			if (denominator == 0)
			{
				throw new DivideByZeroException("Denominator cannot be zero.");
			}

			return (double)numerator / denominator;
		}
	}
}
