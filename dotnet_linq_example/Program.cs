using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExample
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Person> people = new List<Person>
			{
				new Person("Alice", 30),
				new Person("Bob", 25),
				new Person("Carol", 35),
				new Person("David", 28)
			};

			// 30歳以上の人を選択し、名前でソート
			var filteredSortedPeople = people
				.Where(p => p.Age >= 30)
				.OrderBy(p => p.Name)
				.Select(p => new { p.Name, p.Age });

			Console.WriteLine("People aged 30 or older:");
			foreach (var person in filteredSortedPeople)
			{
				Console.WriteLine($"{person.Name} is {person.Age} years old.");
			}
		}
	}

	class Person
	{
		public string Name { get; }
		public int Age { get; }

		public Person(string name, int age)
		{
			Name = name;
			Age = age;
		}
	}
}
