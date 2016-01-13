public class Enumerator<T> : System.ValueType, IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator
{

	// Methods
	public virtual bool MoveNext() {}
	public virtual void Dispose() {}
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public T Current { get{} }
}

