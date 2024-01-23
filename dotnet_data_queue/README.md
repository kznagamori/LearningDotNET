# キュー構造

C#でキュー（ `Queue` ）構造を実装するサンプルプログラムを提供します。キューは一般的に「先入れ先出し」（ `FIFO: First In, First Out` ）の原則に基づいて動作します。この例では、キューを実装するために、独自の `Queue` クラスを作成し、それに要素を追加（ `Enqueue` ）し、要素を取り出す（ `Dequeue` ）方法を示します。

```csharp
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
```

このプログラムでは、ジェネリック型の `Queue` クラスを定義しています。内部では、連結リストを使用してキューの要素を管理しています。`Enqueue` メソッドはキューの末尾に要素を追加し、`Dequeue` メソッドはキューの先頭から要素を取り出し、`Peek` メソッドはキューの先頭の要素を参照するために使います。

このコードを実行すると、キューに要素が追加され、その後、順番に要素が取り出され、最後にキューの先頭の要素が表示されます。