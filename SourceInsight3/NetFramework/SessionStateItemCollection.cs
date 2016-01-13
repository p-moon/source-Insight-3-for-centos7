public class SessionStateItemCollection : System.Collections.Specialized.NameObjectCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback, ISessionStateItemCollection
{

	// Constructors
	public SessionStateItemCollection() {}

	// Methods
	public virtual void Remove(string name) {}
	public virtual void RemoveAt(int index) {}
	public virtual void Clear() {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public void Serialize(System.IO.BinaryWriter writer) {}
	public static SessionStateItemCollection Deserialize(System.IO.BinaryReader reader) {}
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual void OnDeserialization(object sender) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool Dirty { get{} set{} }
	public object Item { get{} set{} }
	public object Item { get{} set{} }
	public System.Collections.Specialized.NameObjectCollectionBase.KeysCollection Keys { get{} }
	public int Count { get{} }
}

