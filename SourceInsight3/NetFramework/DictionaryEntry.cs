public class DictionaryEntry : System.ValueType
{

	// Constructors
	public DictionaryEntry(object key, object value) {}

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public object Key { get{} set{} }
	public object Value { get{} set{} }
}

