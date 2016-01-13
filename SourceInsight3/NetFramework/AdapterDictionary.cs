public class AdapterDictionary : System.Collections.Specialized.OrderedDictionary, System.Collections.Specialized.IOrderedDictionary, System.Collections.IDictionary, System.Collections.ICollection, System.Collections.IEnumerable, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback
{

	// Constructors
	public AdapterDictionary() {}

	// Methods
	public virtual void Add(object key, object value) {}
	public virtual void Clear() {}
	public System.Collections.Specialized.OrderedDictionary AsReadOnly() {}
	public virtual bool Contains(object key) {}
	public virtual void CopyTo(System.Array array, int index) {}
	public virtual void Insert(int index, object key, object value) {}
	public virtual void RemoveAt(int index) {}
	public virtual void Remove(object key) {}
	public virtual System.Collections.IDictionaryEnumerator GetEnumerator() {}
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Item { get{} set{} }
	public int Count { get{} }
	public bool IsReadOnly { get{} }
	public System.Collections.ICollection Keys { get{} }
	public object Item { get{} set{} }
	public object Item { get{} set{} }
	public System.Collections.ICollection Values { get{} }
}

