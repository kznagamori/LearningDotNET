using System;

namespace StringFormatSample
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = 123;
			string decimalFormat = $"{number:D5}"; // 00123 (5桁の10進数、0パディング)
			string hexFormat = $"{number:X}";      // 7B (16進数)
			string octalFormat = $"{Convert.ToString(number, 8)}"; // 173 (8進数)

			double floatingNumber = 123.456789;
			string floatFormat = $"{floatingNumber:F3}"; // 123.457 (小数点以下3桁)
			string scientificFormat = $"{floatingNumber:E2}"; // 1.23E+002 (指数形式)

			DateTime now = DateTime.Now;
			string dateFormat = $"{now:d}";   // MM/dd/yyyy
			string timeFormat = $"{now:T}";   // HH:mm:ss
			string customFormat = $"{now:yyyy年MM月dd日 HH時mm分ss秒}"; // 2024年01月19日 15時45分30秒

			string text = "Hello World";
			string padRight = $"{text,-10}"; // "Hello World     " (右詰め、10文字分のスペース)
			string padLeft = $"{text,10}";   // "     Hello World" (左詰め、10文字分のスペース)
			string substring = $"{text.Substring(0, 5)}"; // "Hello" (最初の5文字)

		}
	}
}
