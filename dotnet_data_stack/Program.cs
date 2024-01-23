using System;

public class Stack<T>
{
	private Node? top;

	private class Node
	{
		public T Data;
		public Node? Next;

		public Node(T data)
		{
			Data = data;
			Next = null;
		}
	}

	public Stack()
	{
		top = null;
	}

	public bool IsEmpty()
	{
		return top == null;
	}

	public void Push(T item)
	{
		Node newNode = new Node(item)
		{
			Next = top
		};
		top = newNode;
	}

	public T? Pop()
	{
		if (IsEmpty())
		{
			throw new InvalidOperationException("Stack is empty");
		}
		if (top == null)
		{
			throw new InvalidOperationException("Stack is empty");
		}
		T? item = top.Data;
		top = top.Next;
		return item;
	}

	public T? Peek()
	{
		if (IsEmpty())
		{
			throw new InvalidOperationException("Stack is empty");
		}
		if (top == null)
		{
			throw new InvalidOperationException("Stack is empty");
		}
		return top.Data;
	}
}

class Program
{
	static void Main(string[] args)
	{
		Stack<int> stack = new Stack<int>();

		// 要素の追加
		stack.Push(1);
		stack.Push(2);
		stack.Push(3);

		// 先頭の要素を参照
		Console.WriteLine("Peek: " + stack.Peek());

		// 要素の取り出し
		Console.WriteLine("Pop: " + stack.Pop());
		Console.WriteLine("Pop: " + stack.Pop());
	}
}
