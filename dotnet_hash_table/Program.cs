using System;
using System.Collections.Generic;

public class HashTable<K, V>
{
	private class HashNode
	{
		public K Key;
		public V Value;
		public HashNode? Next;

		public HashNode(K key, V value)
		{
			Key = key;
			Value = value;
			Next = null;
		}
	}

	private List<HashNode> buckets;
	private int size;

	public HashTable(int size)
	{
		buckets = new List<HashNode>(new HashNode[size]);
		this.size = size;
	}

	private int GetBucketIndex(K? key)
	{
		if (key == null)
		{
			throw new ArgumentNullException(nameof(key));
		}
		int hashCode = key.GetHashCode();
		int index = hashCode % size;
		return Math.Abs(index);
	}

	public void Add(K key, V value)
	{
		int bucketIndex = GetBucketIndex(key);
		HashNode? head = buckets[bucketIndex];

		while (head != null)
		{
			if (head.Key?.Equals(key) ?? false)
			{
				head.Value = value;
				return;
			}
			head = head.Next;
		}

		head = buckets[bucketIndex];
		HashNode newNode = new HashNode(key, value);
		newNode.Next = head;
		buckets[bucketIndex] = newNode;
	}

	public V Get(K key)
	{
		int bucketIndex = GetBucketIndex(key);
		HashNode? head = buckets[bucketIndex];

		while (head != null)
		{
			if (head.Key?.Equals(key) ?? false)
			{
				return head.Value;
			}
			head = head.Next;
		}

		throw new KeyNotFoundException("Key not found");
	}
}

class Program
{
	static void Main(string[] args)
	{
		HashTable<string, int> hashTable = new HashTable<string, int>(10);

		hashTable.Add("key1", 1);
		hashTable.Add("key2", 2);
		hashTable.Add("key3", 3);

		Console.WriteLine("Value for 'key1': " + hashTable.Get("key1"));
		Console.WriteLine("Value for 'key2': " + hashTable.Get("key2"));
		Console.WriteLine("Value for 'key3': " + hashTable.Get("key3"));
	}
}
