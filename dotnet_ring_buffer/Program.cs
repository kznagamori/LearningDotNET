using System;

public class RingBuffer<T>
{
	private T[] buffer;
	private int head;
	private int tail;
	private int count;
	private int capacity;

	public RingBuffer(int capacity)
	{
		this.capacity = capacity;
		buffer = new T[capacity];
		head = 0;
		tail = 0;
		count = 0;
	}

	public void Push(T item)
	{
		if (count == capacity)
		{
			throw new InvalidOperationException("Buffer is full");
		}

		buffer[tail] = item;
		tail = (tail + 1) % capacity;
		count++;
	}

	public T Pop()
	{
		if (count == 0)
		{
			throw new InvalidOperationException("Buffer is empty");
		}

		T item = buffer[head];
		head = (head + 1) % capacity;
		count--;
		return item;
	}

	public T Get(int index)
	{
		if (index < 0 || index >= count)
		{
			throw new ArgumentOutOfRangeException("Index out of range");
		}

		return buffer[(head + index) % capacity];
	}
}

class Program
{
	static void Main(string[] args)
	{
		RingBuffer<int> ringBuffer = new RingBuffer<int>(5);

		// データの追加
		ringBuffer.Push(1);
		ringBuffer.Push(2);
		ringBuffer.Push(3);

		// データの参照
		Console.WriteLine("Item at index 1: " + ringBuffer.Get(1));

		// データの取得
		Console.WriteLine("Pop item: " + ringBuffer.Pop());
		Console.WriteLine("Pop item: " + ringBuffer.Pop());
	}
}
