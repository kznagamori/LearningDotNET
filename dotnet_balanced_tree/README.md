# 平衡二分木構造

C#で平衡二分木（ `AVL Tree` ）を実装するためのサンプルプログラムを提供します。`AVL` 木は、任意のノードの左右の子の高さの差が最大でも1であるように、自己バランスを保つ二分探索木です。この木では、挿入や削除の際に回転操作を行って木のバランスを保ちます。

以下は平衡二分木（ `AVL` 木）を実装する簡単な例です：

```csharp
using System;

public class AVLTree
{
	public class Node
	{
		public int Data;
		public Node? Left;
		public Node? Right;
		public int Height;

		public Node(int data)
		{
			Data = data;
			Height = 1; // 新規ノードは常に高さ1で開始
		}
	}

	public Node? Root;

	// ノードの高さを取得
	private int Height(Node? N)
	{
		if (N == null)
			return 0;
		return N.Height;
	}

	// 右回転
	private Node? RightRotate(Node? y)
	{
		if (y == null)
		{
			throw new ArgumentNullException(nameof(y));
		}
		Node? x = y.Left;
		if (x == null)
		{
			throw new ArgumentNullException(nameof(x));
		}
		Node? T2 = x.Right;

		x.Right = y;
		y.Left = T2;

		y.Height = Math.Max(Height(y.Left), Height(y.Right)) + 1;
		x.Height = Math.Max(Height(x.Left), Height(x.Right)) + 1;

		return x;
	}

	// 左回転
	private Node? LeftRotate(Node? x)
	{
		if (x == null)
		{
			throw new ArgumentNullException(nameof(x));
		}
		Node? y = x.Right;
		if (y == null)
		{
			throw new ArgumentNullException(nameof(y));
		}
		Node? T2 = y.Left;

		y.Left = x;
		x.Right = T2;

		x.Height = Math.Max(Height(x.Left), Height(x.Right)) + 1;
		y.Height = Math.Max(Height(y.Left), Height(y.Right)) + 1;

		return y;
	}

	// バランスファクターを取得
	private int GetBalanceFactor(Node? N)
	{
		if (N == null)
			return 0;
		return Height(N.Left) - Height(N.Right);
	}

	// ノードの挿入
	public Node? Insert(Node? node, int data)
	{
		if (node == null)
			return (new Node(data));

		if (data < node.Data)
			node.Left = Insert(node.Left, data);
		else if (data > node.Data)
			node.Right = Insert(node.Right, data);
		else // 同じデータは許可されない
			return node;

		node.Height = 1 + Math.Max(Height(node.Left), Height(node.Right));

		int balance = GetBalanceFactor(node);

		// 左左ケース
		if (balance > 1 && node.Left != null && data < node.Left.Data)
			return RightRotate(node);

		// 右右ケース
		if (balance < -1 && node.Right != null && data > node.Right.Data)
			return LeftRotate(node);

		// 左右ケース
		if (balance > 1 && node.Left != null && data > node.Left.Data)
		{
			node.Left = LeftRotate(node.Left);
			return RightRotate(node);
		}

		// 右左ケース
		if (balance < -1 && node.Right != null && data < node.Right.Data)
		{
			node.Right = RightRotate(node.Right);
			return LeftRotate(node);
		}

		return node;
	}

	// 二分木を中順巡回で表示
	public void InOrder(Node? root)
	{
		if (root != null)
		{
			InOrder(root.Left);
			Console.Write(root.Data + " ");
			InOrder(root.Right);
		}
	}
}

class Program
{
	static void Main(string[] args)
	{
		AVLTree tree = new AVLTree();

		tree.Root = tree.Insert(tree.Root, 10);
		tree.Root = tree.Insert(tree.Root, 20);
		tree.Root = tree.Insert(tree.Root, 30);
		tree.Root = tree.Insert(tree.Root, 40);
		tree.Root = tree.Insert(tree.Root, 50);
		tree.Root = tree.Insert(tree.Root, 25);

		Console.WriteLine("In-order traversal of the constructed AVL tree is:");
		tree.InOrder(tree.Root);
	}
}
```

このプログラムでは、`AVLTree` クラスとその内部クラスである `Node` クラスを定義しています。`Node` クラスは `AVL` 木の各ノードを表し、`AVLTree` クラスはAVL木全体を管理します。`Insert` メソッドは新しいノードを挿入し、必要に応じて木を回転させてバランスを取ります。`InOrder` メソッドはAVL木を中順巡回でトラバースします。

このコードを実行すると、`AVL` 木が作成され、ノードがバランス良く追加され、木が中順巡回でトラバースされます。
