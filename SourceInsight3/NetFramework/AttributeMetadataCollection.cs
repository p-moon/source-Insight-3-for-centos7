public class AttributeMetadataCollection : System.Collections.ReadOnlyCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public bool Contains(AttributeMetadata metadata) {}
	public int IndexOf(AttributeMetadata metadata) {}
	public void CopyTo(AttributeMetadata[] metadata, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public AttributeMetadata Item { get{} }
	public int Count { get{} }
}

