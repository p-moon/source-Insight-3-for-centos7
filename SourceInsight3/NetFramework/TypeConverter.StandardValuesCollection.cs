public class StandardValuesCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public StandardValuesCollection(System.Collections.ICollection values) {}

	// Methods
	public void CopyTo(System.Array array, int index) {}
	public System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public object Item { get{} }
}

