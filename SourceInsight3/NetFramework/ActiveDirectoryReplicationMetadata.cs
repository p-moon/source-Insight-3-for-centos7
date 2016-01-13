public class ActiveDirectoryReplicationMetadata : System.Collections.DictionaryBase, System.Collections.IDictionary, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public bool Contains(string attributeName) {}
	public void CopyTo(AttributeMetadata[] array, int index) {}
	public virtual void CopyTo(System.Array array, int index) {}
	public virtual void Clear() {}
	public virtual System.Collections.IDictionaryEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public AttributeMetadata Item { get{} }
	public ReadOnlyStringCollection AttributeNames { get{} }
	public AttributeMetadataCollection Values { get{} }
	public int Count { get{} }
}

