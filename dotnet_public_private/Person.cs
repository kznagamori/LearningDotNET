using System;

namespace PublicPrivateExample
{
	public class Person
	{
		public string Name { get; private set; }
		public int Age { get; private set; }

		private SecretIdentity secretIdentity;

		class SecretIdentity
		{
			private string SecretName;

			public SecretIdentity(string secretName)
			{
				SecretName = secretName;
			}

			public void DisplaySecret()
			{
				Console.WriteLine($"Secret Identity: {SecretName}");
			}
		}

		public Person(string name, int age, string secretName)
		{
			Name = name;
			Age = age;
			secretIdentity = new SecretIdentity(secretName);
		}

		public void DisplayPublicInfo()
		{
			Console.WriteLine($"Name: {Name}, Age: {Age}");
			secretIdentity.DisplaySecret();
		}
	}
}
