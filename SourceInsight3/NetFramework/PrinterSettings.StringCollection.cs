public class StringCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public StringCollection(string[] array) {}

	// Methods
	public System.Collections.IEnumerator GetEnumerator() {}
	public void CopyTo(string[] strings, int index) {}
	public int Add(string value) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public string Item { get{} }
}

