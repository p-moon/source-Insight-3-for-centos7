public class ScopeRecord<V> : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public int scopeCount;
	public string ncName;
	public string nsUri;
	public V value;

	// Properties
	public bool IsVariable { get{} }
	public bool IsNamespace { get{} }
	public bool IsExNamespace { get{} }
}

