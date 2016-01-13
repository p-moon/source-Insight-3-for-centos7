public class EqualityComparer<T> : System.Collections.IEqualityComparer, IEqualityComparer<T>
{

	// Methods
	public abstract virtual bool Equals(T x, T y) {}
	public abstract virtual int GetHashCode(T obj) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public EqualityComparer<T> Default { get{} }
}

