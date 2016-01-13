public class Hashtable : IDictionary, ICollection, IEnumerable, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback, System.ICloneable
{

	// Constructors
	public Hashtable() {}
	public Hashtable(int capacity) {}
	public Hashtable(int capacity, float loadFactor) {}
	public Hashtable(int capacity, float loadFactor, IHashCodeProvider hcp, IComparer comparer) {}
	public Hashtable(int capacity, float loadFactor, IEqualityComparer equalityComparer) {}
	public Hashtable(IHashCodeProvider hcp, IComparer comparer) {}
	public Hashtable(IEqualityComparer equalityComparer) {}
	public Hashtable(int capacity, IHashCodeProvider hcp, IComparer comparer) {}
	public Hashtable(int capacity, IEqualityComparer equalityComparer) {}
	public Hashtable(IDictionary d) {}
	public Hashtable(IDictionary d, float loadFactor) {}
	public Hashtable(IDictionary d, IHashCodeProvider hcp, IComparer comparer) {}
	public Hashtable(IDictionary d, IEqualityComparer equalityComparer) {}
	public Hashtable(IDictionary d, float loadFactor, IHashCodeProvider hcp, IComparer comparer) {}
	public Hashtable(IDictionary d, float loadFactor, IEqualityComparer equalityComparer) {}

	// Methods
	public virtual IDictionaryEnumerator GetEnumerator() {}
	public virtual void Add(object key, object value) {}
	public virtual void Clear() {}
	public virtual object Clone() {}
	public virtual bool Contains(object key) {}
	public virtual bool ContainsKey(object key) {}
	public virtual bool ContainsValue(object value) {}
	public virtual void CopyTo(System.Array array, int arrayIndex) {}
	public virtual void Remove(object key) {}
	public static Hashtable Synchronized(Hashtable table) {}
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
	public ICollection Keys { get{} }
	public ICollection Values { get{} }
	public object SyncRoot { get{} }
	public int Count { get{} }
}

