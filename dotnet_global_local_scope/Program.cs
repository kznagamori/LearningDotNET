using System;
using GlobalExample;

namespace GlobalExample
{
	class Program
	{
		// この変数と関数はこのファイル内からのみアクセス可能です。
		private static string LocalVariable = "Local Value";

		private static void DisplayLocalVariable()
		{
			Console.WriteLine($"Local Variable: {LocalVariable}");
		}

		static void Main(string[] args)
		{
			// グローバル変数を表示
			GlobalData.DisplayGlobalVariable();

			// グローバル変数を変更
			GlobalData.ModifyGlobalVariable("New Value");

			// 変更後のグローバル変数を表示
			GlobalData.DisplayGlobalVariable();

			// ローカル変数の表示
			DisplayLocalVariable();

			// GlobalData.cs内のローカル変数や関数にはアクセスできない（以下はコメントアウト）
			// Console.WriteLine(GlobalData.LocalVariableInGlobalData);  // アクセス不可
			// GlobalData.DisplayLocalVariableInGlobalData();           // アクセス不可
		}
	}
}
