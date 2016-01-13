public class ConfigurationSectionGroupCollection : System.Collections.Specialized.NameObjectCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback
{

	// Methods
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public void Add(string name, ConfigurationSectionGroup sectionGroup) {}
	public void Clear() {}
	public void CopyTo(ConfigurationSectionGroup[] array, int index) {}
	public ConfigurationSectionGroup Get(int index) {}
	public ConfigurationSectionGroup Get(string name) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public string GetKey(int index) {}
	public void Remove(string name) {}
	public void RemoveAt(int index) {}
	public virtual void OnDeserialization(object sender) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ConfigurationSectionGroup Item { get{} }
	public ConfigurationSectionGroup Item { get{} }
	public int Count { get{} }
	public System.Collections.Specialized.NameObjectCollectionBase.KeysCollection Keys { get{} }
}

