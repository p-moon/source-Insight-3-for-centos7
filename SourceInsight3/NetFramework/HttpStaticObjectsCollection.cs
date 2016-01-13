public class HttpStaticObjectsCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public HttpStaticObjectsCollection() {}

	// Methods
	public object GetObject(string name) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public virtual void CopyTo(System.Array array, int index) {}
	public void Serialize(System.IO.BinaryWriter writer) {}
	public static HttpStaticObjectsCollection Deserialize(System.IO.BinaryReader reader) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool NeverAccessed { get{} }
	public object Item { get{} }
	public int Count { get{} }
	public object SyncRoot { get{} }
	public bool IsReadOnly { get{} }
	public bool IsSynchronized { get{} }
}

