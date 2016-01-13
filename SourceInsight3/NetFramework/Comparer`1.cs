public class Comparer<T> : System.Collections.IComparer, IComparer<T>
{

	// Methods
	public abstract virtual int Compare(T x, T y) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Comparer<T> Default { get{} }
}

