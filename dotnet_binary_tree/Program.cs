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
