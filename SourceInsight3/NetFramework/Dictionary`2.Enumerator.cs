public class Enumerator<TKey,TValue> : System.ValueType, IEnumerator<KeyValuePair<TKey,TValue>>, System.IDisposable, System.Collections.IEnumerator, System.Collections.IDictionaryEnumerator
{

	// Methods
	public virtual bool MoveNext() {}
	public virtual void Dispose() {}
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public KeyValuePair<TKey,TValue> Current { get{} }
}

