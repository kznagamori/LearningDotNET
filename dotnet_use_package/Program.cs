using System;
using Newtonsoft.Json;

namespace MyJsonApp
{
	class Program
	{
		static void Main(string[] args)
		{
			var person = new Person
			{
				Name = "Alice",
				Age = 30
			};

			string json = JsonConvert.SerializeObject(person);
			Console.WriteLine("Serialized JSON:");
			Console.WriteLine(json);

			var deserializedPerson = JsonConvert.DeserializeObject<Person>(json);
			Console.WriteLine("Deserialized JSON:");
			if (deserializedPerson != null)
			{
				Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
			}
		}
	}

	public class Person
	{
		public string? Name { get; set; }
		public int Age { get; set; }
	}
}
