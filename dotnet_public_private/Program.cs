using System;
using PublicPrivateExample;

namespace PublicPrivateExample
{
	class Program
	{
		static void Main(string[] args)
		{
			var person = new Person("Alice", 30, "SuperAlice");
			person.DisplayPublicInfo();

			// 以下のコードはコンパイルエラーになります
			// Console.WriteLine(person.secretIdentity.SecretName); // 秘密のアイデンティティへの直接アクセスは許可されていません
		}
	}
}
