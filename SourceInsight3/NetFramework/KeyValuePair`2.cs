public class KeyValuePair<TKey,TValue> : System.ValueType
{

	// Constructors
	public KeyValuePair(TKey key, TValue value) {}

	// Methods
	public virtual string ToString() {}
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public Type GetType() {}

	// Properties
	public TKey Key { get{} }
	public TValue Value { get{} }
}

