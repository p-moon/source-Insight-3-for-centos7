public class HttpCookieCollection : System.Collections.Specialized.NameObjectCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback
{

	// Constructors
	public HttpCookieCollection() {}

	// Methods
	public void Add(HttpCookie cookie) {}
	public void CopyTo(System.Array dest, int index) {}
	public void Set(HttpCookie cookie) {}
	public void Remove(string name) {}
	public void Clear() {}
	public HttpCookie Get(string name) {}
	public HttpCookie Get(int index) {}
	public string GetKey(int index) {}
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual void OnDeserialization(object sender) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public HttpCookie Item { get{} }
	public HttpCookie Item { get{} }
	public string[] AllKeys { get{} }
	public int Count { get{} }
	public System.Collections.Specialized.NameObjectCollectionBase.KeysCollection Keys { get{} }
}

