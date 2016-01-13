public class HttpApplicationState : System.Collections.Specialized.NameObjectCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback
{

	// Methods
	public void Add(string name, object value) {}
	public void Set(string name, object value) {}
	public void Remove(string name) {}
	public void RemoveAt(int index) {}
	public void Clear() {}
	public void RemoveAll() {}
	public object Get(string name) {}
	public object Get(int index) {}
	public string GetKey(int index) {}
	public void Lock() {}
	public void UnLock() {}
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual void OnDeserialization(object sender) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public object Item { get{} set{} }
	public object Item { get{} }
	public string[] AllKeys { get{} }
	public HttpApplicationState Contents { get{} }
	public HttpStaticObjectsCollection StaticObjects { get{} }
	public System.Collections.Specialized.NameObjectCollectionBase.KeysCollection Keys { get{} }
}

