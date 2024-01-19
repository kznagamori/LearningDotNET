using System;
using LibraryProject;

namespace ConsoleAppProject
{
	class Program
	{
		static void Main(string[] args)
		{
			var person = new Person("Alice", 30);
			var message = Greeter.Greet(person);
			Console.WriteLine(message);
		}
	}
}