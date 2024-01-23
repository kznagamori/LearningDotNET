namespace GenericExample
{
	public class Box<T>
	{
		public T Content { get; set; }

		public Box(T content)
		{
			Content = content;
		}
	}
}
