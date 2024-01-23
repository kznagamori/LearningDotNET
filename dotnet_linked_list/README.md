# リンクドリスト構造

C#でリンクドリストを実装するためのサンプルプログラムを提供します。ここでは基本的なリンクドリストの構造を作成し、いくつかの要素をリストに追加し、そしてそれらを表示する方法を示します。

この例では、`Node` クラスを定義してリストの各要素を表し、`LinkedList` クラスでリストの操作を管理します。

```csharp
using System;

namespace LinkedListExample
{
	// リンクドリストのノードを表すクラス
	public class Node
	{
		public int Data;
		public Node? Next;

		public Node(int data)
		{
			Data = data;
			Next = null;
		}
	}

	// リンクドリストを管理するクラス
	public class LinkedList
	{
		private Node? head;

		public LinkedList()
		{
			head = null;
		}

		// リストの末尾に要素を追加
		public void Append(int data)
		{
			if (head == null)
			{
				head = new Node(data);
				return;
			}

			Node? current = head;
			while (current.Next != null)
			{
				current = current.Next;
			}

			current.Next = new Node(data);
		}

		// リストの要素を表示
		public void Print()
		{
			Node? current = head;
			while (current != null)
			{
				Console.Write(current.Data + " ");
				current = current.Next;
			}
			Console.WriteLine();
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			LinkedList list = new LinkedList();

			list.Append(1);
			list.Append(2);
			list.Append(3);

			Console.WriteLine("Linked List:");
			list.Print();
		}
	}
}
```

このプログラムでは、`LinkedList` クラスに `Append` メソッドを使ってリストに新しい要素を追加し、`Print` メソッドを使ってリストの内容を表示しています。Node クラスはリストの各要素（ノード）を表しており、`Data` プロパティで要素のデータを保持し、`Next` プロパティで次のノードへのリンクを保持します。

このコードを実行すると、リンクドリストが作成され、3つの要素（1, 2, 3）が追加され、その後、リストの内容が表示されます。
