using System;

namespace GlobalExample
{
	public static class GlobalData
	{
		public static string GlobalVariable = "Initial Value";

		public static void DisplayGlobalVariable()
		{
			Console.WriteLine($"Global Variable: {GlobalVariable}");
		}

		public static void ModifyGlobalVariable(string newValue)
		{
			GlobalVariable = newValue;
		}
	}
}
