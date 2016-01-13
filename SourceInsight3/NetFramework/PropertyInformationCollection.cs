public class PropertyInformationCollection : System.Collections.Specialized.NameObjectCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback
{

	// Methods
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public void CopyTo(PropertyInformation[] array, int index) {}
	public virtual void OnDeserialization(object sender) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public PropertyInformation Item { get{} }
	public int Count { get{} }
	public System.Collections.Specialized.NameObjectCollectionBase.KeysCollection Keys { get{} }
}

