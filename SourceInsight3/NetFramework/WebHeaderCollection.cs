public class WebHeaderCollection : System.Collections.Specialized.NameValueCollection, System.Collections.ICollection, System.Collections.IEnumerable, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback
{

	// Constructors
	public WebHeaderCollection() {}

	// Methods
	public void Add(HttpRequestHeader header, string value) {}
	public void Add(HttpResponseHeader header, string value) {}
	public void Set(HttpRequestHeader header, string value) {}
	public void Set(HttpResponseHeader header, string value) {}
	public void Remove(HttpRequestHeader header) {}
	public void Remove(HttpResponseHeader header) {}
	public virtual void Add(string name, string value) {}
	public void Add(string header) {}
	public virtual void Set(string name, string value) {}
	public virtual void Remove(string name) {}
	public virtual string[] GetValues(string header) {}
	public virtual string ToString() {}
	public byte[] ToByteArray() {}
	public static bool IsRestricted(string headerName) {}
	public static bool IsRestricted(string headerName, bool response) {}
	public virtual void OnDeserialization(object sender) {}
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) {}
	public virtual string Get(string name) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public virtual string Get(int index) {}
	public virtual string[] GetValues(int index) {}
	public virtual string GetKey(int index) {}
	public virtual void Clear() {}
	public void Add(System.Collections.Specialized.NameValueCollection c) {}
	public void CopyTo(System.Array dest, int index) {}
	public bool HasKeys() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Item { get{} set{} }
	public string Item { get{} set{} }
	public int Count { get{} }
	public System.Collections.Specialized.NameObjectCollectionBase.KeysCollection Keys { get{} }
	public string[] AllKeys { get{} }
	public string Item { get{} set{} }
	public string Item { get{} }
}

