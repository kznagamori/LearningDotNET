# スタック構造

C#でスタック（ `Stack` ）構造を実装するサンプルプログラムを作成します。スタックは「後入れ先出し」（ `LIFO: Last In, First Out` ）のデータ構造です。この例では、自作のスタックを実装し、それに要素をプッシュ（ `Push` ）し、ポップ（ `Pop` ）する方法を示します。

以下は、そのようなスタックを実装する簡単な例です：

```csharp
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
```

このプログラムでは、ジェネリック型の `Stack` クラスを定義しています。内部では、連結リストを使用してスタックの要素を管理しています。`Push` メソッドはスタックのトップに要素を追加し、`Pop` メソッドはスタックのトップから要素を取り出し、`Peek` メソッドはスタックのトップの要素を参照するために使います。

このコードを実行すると、スタックに要素が追加され、その後、順番に要素が取り出され、最後にスタックのトップの要素が表示されます。
