public class Collection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback
{

	// Constructors
	public Collection() {}

	// Methods
	public void Add(object Item, string Key, object Before, object After) {}
	public void Clear() {}
	public bool Contains(string Key) {}
	public void Remove(string Key) {}
	public void Remove(int Index) {}
	public System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object Item { get{} }
	public object Item { get{} }
	public object Item { get{} }
	public int Count { get{} }
}

