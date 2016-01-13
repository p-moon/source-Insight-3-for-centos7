public class TransformerTypeCollection : System.Collections.ReadOnlyCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public TransformerTypeCollection() {}
	public TransformerTypeCollection(System.Collections.ICollection transformerTypes) {}
	public TransformerTypeCollection(TransformerTypeCollection existingTransformerTypes, System.Collections.ICollection transformerTypes) {}

	// Methods
	public bool Contains(Type value) {}
	public int IndexOf(Type value) {}
	public void CopyTo(Type[] array, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public TransformerTypeCollection Empty;

	// Properties
	public Type Item { get{} }
	public int Count { get{} }
}

