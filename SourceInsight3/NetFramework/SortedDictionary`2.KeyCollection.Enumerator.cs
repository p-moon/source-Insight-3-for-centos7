public class Enumerator<TKey,TValue> : System.ValueType, IEnumerator<TKey>, System.IDisposable, System.Collections.IEnumerator
{

	// Methods
	public virtual void Dispose() {}
	public virtual bool MoveNext() {}
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public TKey Current { get{} }
}

