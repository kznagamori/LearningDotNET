namespace MultiFileApp
{
	public static class Greeter
	{
		public static string Greet(Person person)
		{
			return $"Hello, {person.Name}! You are {person.Age} years old.";
		}
	}
}
