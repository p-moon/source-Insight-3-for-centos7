public class VirtualDirectoryMappingCollection : System.Collections.Specialized.NameObjectCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback
{

	// Constructors
	public VirtualDirectoryMappingCollection() {}

	// Methods
	public void Add(string virtualDirectory, VirtualDirectoryMapping mapping) {}
	public void Clear() {}
	public void CopyTo(VirtualDirectoryMapping[] array, int index) {}
	public VirtualDirectoryMapping Get(int index) {}
	public VirtualDirectoryMapping Get(string virtualDirectory) {}
	public string GetKey(int index) {}
	public void Remove(string virtualDirectory) {}
	public void RemoveAt(int index) {}
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual void OnDeserialization(object sender) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Collections.ICollection AllKeys { get{} }
	public VirtualDirectoryMapping Item { get{} }
	public VirtualDirectoryMapping Item { get{} }
	public int Count { get{} }
	public System.Collections.Specialized.NameObjectCollectionBase.KeysCollection Keys { get{} }
}

