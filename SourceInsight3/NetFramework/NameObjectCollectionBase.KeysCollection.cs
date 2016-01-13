public class KeysCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public virtual string Get(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Item { get{} }
	public int Count { get{} }
}

