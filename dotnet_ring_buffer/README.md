# リングバッファ構造

C#でリングバッファ（円環バッファ）を実装するサンプルプログラムを提供します。リングバッファは、固定サイズの配列を使用して実装され、`push` メソッドでデータを追加し、`pop` メソッドでデータを取得し、`get` メソッドでデータを参照します。

以下は、そのようなリングバッファを実装する簡単な例です：

```csharp
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
```

このプログラムでは、汎用型のリングバッファを作成しています。`Push` メソッドはバッファに要素を追加し、`Pop` メソッドはバッファから要素を取得し、`Get` メソッドは指定されたインデックスの要素を参照します。

`RingBuffer` クラスは、内部配列 `buffer` でデータを保持し、`head` と `tail` インデックスを使用してバッファの開始と終了を追跡します。バッファが満杯または空の場合に適切な例外をスローします。

このコードを実行すると、バッファに要素が追加され、特定のインデックスの要素が参照され、要素が取り出されるプロセスが示されます。
