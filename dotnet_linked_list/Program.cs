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
