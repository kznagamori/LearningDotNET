using System;

public class Queue<T>
{
	private Node? head;
	private Node? tail;

	private class Node
	{
		public T? Data;
		public Node? Next;

		public Node(T data)
		{
			this.Data = data;
			this.Next = null;
		}
	}

	public Queue()
	{
		head = null;
		tail = null;
	}

	public bool IsEmpty()
	{
		return head == null;
	}

	public void Enqueue(T item)
	{
		Node? newNode = new Node(item);

		if (tail != null)
		{
			tail.Next = newNode;
		}

		tail = newNode;

		if (head == null)
		{
			head = tail;
		}
	}

	public T? Dequeue()
	{
		if (IsEmpty())
		{
			throw new InvalidOperationException("Queue is empty");
		}
		if (head == null)
		{
			throw new InvalidOperationException("Queue is empty");
		}
		T? item = head.Data;
		head = head.Next;

		if (head == null)
		{
			tail = null;
		}

		return item;
	}

	public T? Peek()
	{
		if (IsEmpty())
		{
			throw new InvalidOperationException("Queue is empty");
		}
		if (head == null)
		{
			throw new InvalidOperationException("Queue is empty");
		}
		return head.Data;
	}
}

class Program
{
	static void Main(string[] args)
	{
		Queue<int> queue = new Queue<int>();

		// 要素の追加
		queue.Enqueue(1);
		queue.Enqueue(2);
		queue.Enqueue(3);

		// 要素の取り出し
		Console.WriteLine("Dequeue: " + queue.Dequeue());
		Console.WriteLine("Dequeue: " + queue.Dequeue());

		// 先頭の要素の参照
		Console.WriteLine("Peek: " + queue.Peek());
	}
}
