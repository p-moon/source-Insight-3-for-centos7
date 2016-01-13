public class ArraySegment<T> : ValueType
{

	// Constructors
	public ArraySegment(T[] array) {}
	public ArraySegment(T[] array, int offset, int count) {}

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public bool Equals(ArraySegment<T> obj) {}
	public static bool op_Equality(ArraySegment<T> a, ArraySegment<T> b) {}
	public static bool op_Inequality(ArraySegment<T> a, ArraySegment<T> b) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public T[] Array { get{} }
	public int Offset { get{} }
	public int Count { get{} }
}

