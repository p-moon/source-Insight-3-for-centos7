public class SettingsContext : System.Collections.Hashtable, System.Collections.IDictionary, System.Collections.ICollection, System.Collections.IEnumerable, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback, System.ICloneable
{

	// Constructors
	public SettingsContext() {}

	// Methods
	public virtual System.Collections.IDictionaryEnumerator GetEnumerator() {}
	public virtual void Add(object key, object value) {}
	public virtual void Clear() {}
	public virtual object Clone() {}
	public virtual bool Contains(object key) {}
	public virtual bool ContainsKey(object key) {}
	public virtual bool ContainsValue(object value) {}
	public virtual void CopyTo(System.Array array, int arrayIndex) {}
	public virtual void Remove(object key) {}
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual void OnDeserialization(object sender) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object Item { get{} set{} }
	public bool IsReadOnly { get{} }
	public bool IsFixedSize { get{} }
	public bool IsSynchronized { get{} }
	public System.Collections.ICollection Keys { get{} }
	public System.Collections.ICollection Values { get{} }
	public object SyncRoot { get{} }
	public int Count { get{} }
}

