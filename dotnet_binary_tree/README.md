# 二分木構造

C#で二分木（ `Binary Tree` ）構造を実装するサンプルプログラムを提供します。この例では、二分木の基本的な構造を作成し、ノードの挿入、検索、および木のトラバース（中順巡回）を行うメソッドを実装します。

以下はそのような二分木を実装する簡単な例です：

```csharp
using System;

public class BinaryTree
{
	public class Node
	{
		public int Data;
		public Node? Left;
		public Node? Right;

		public Node(int data)
		{
			Data = data;
			Left = null;
			Right = null;
		}
	}

	public Node? Root;

	public BinaryTree()
	{
		Root = null;
	}

	public void Insert(int data)
	{
		Root = InsertRecursively(Root, data);
	}

	private Node? InsertRecursively(Node? root, int data)
	{
		if (root == null)
		{
			root = new Node(data);
			return root;
		}

		if (data < root.Data)
		{
			root.Left = InsertRecursively(root.Left, data);
		}
		else if (data > root.Data)
		{
			root.Right = InsertRecursively(root.Right, data);
		}

		return root;
	}

	public bool Search(int data)
	{
		return SearchRecursive(Root, data);
	}

	private bool SearchRecursive(Node? root, int data)
	{
		if (root == null)
		{
			return false;
		}

		if (data == root.Data)
		{
			return true;
		}
		else if (data < root.Data)
		{
			return SearchRecursive(root.Left, data);
		}
		else
		{
			return SearchRecursive(root.Right, data);
		}
	}

	public void InOrderTraversal()
	{
		InOrderTraversalRecursive(Root);
		Console.WriteLine();
	}

	private void InOrderTraversalRecursive(Node? root)
	{
		if (root != null)
		{
			InOrderTraversalRecursive(root.Left);
			Console.Write(root.Data + " ");
			InOrderTraversalRecursive(root.Right);
		}
	}
}

class Program
{
	static void Main(string[] args)
	{
		BinaryTree tree = new BinaryTree();

		tree.Insert(5);
		tree.Insert(3);
		tree.Insert(7);
		tree.Insert(1);
		tree.Insert(4);
		tree.Insert(6);
		tree.Insert(8);

		Console.WriteLine("In-order traversal of binary tree:");
		tree.InOrderTraversal();

		Console.WriteLine("Search for 4 in the tree: " + tree.Search(4));
		Console.WriteLine("Search for 10 in the tree: " + tree.Search(10));
	}
}
```

このプログラムでは、`BinaryTree` クラスとその内部クラスである `Node` クラスを定義しています。`Node` クラスは二分木の各ノードを表し、`BinaryTree` クラスは二分木全体を管理します。`Insert` メソッドは新しいノードを適切な位置に再帰的に挿入し、`Search` メソッドは指定された値を持つノードを再帰的に検索し、`InOrderTraversal` メソッドは二分木を中順巡回でトラバースします。

このコードを実行すると、二分木が作成され、ノードが追加され、木が中順巡回でトラバースされ、特定の値を持つノードの検索が行われます。
