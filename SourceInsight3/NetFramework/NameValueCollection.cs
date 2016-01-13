public class NameValueCollection : NameObjectCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback
{

	// Constructors
	public NameValueCollection(System.Collections.IEqualityComparer equalityComparer) {}
	public NameValueCollection() {}
	public NameValueCollection(NameValueCollection col) {}
	public NameValueCollection(System.Collections.IHashCodeProvider hashProvider, System.Collections.IComparer comparer) {}
	public NameValueCollection(int capacity) {}
	public NameValueCollection(int capacity, System.Collections.IEqualityComparer equalityComparer) {}
	public NameValueCollection(int capacity, NameValueCollection col) {}
	public NameValueCollection(int capacity, System.Collections.IHashCodeProvider hashProvider, System.Collections.IComparer comparer) {}

	// Methods
	public void Add(NameValueCollection c) {}
	public virtual void Clear() {}
	public void CopyTo(System.Array dest, int index) {}
	public bool HasKeys() {}
	public virtual void Add(string name, string value) {}
	public virtual string Get(string name) {}
	public virtual string[] GetValues(string name) {}
	public virtual void Set(string name, string value) {}
	public virtual void Remove(string name) {}
	public virtual string Get(int index) {}
	public virtual string[] GetValues(int index) {}
	public virtual string GetKey(int index) {}
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual void OnDeserialization(object sender) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Item { get{} set{} }
	public string Item { get{} }
	public string[] AllKeys { get{} }
	public int Count { get{} }
	public KeysCollection Keys { get{} }
}

