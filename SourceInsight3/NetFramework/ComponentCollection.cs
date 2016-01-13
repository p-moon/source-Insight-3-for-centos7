public class ComponentCollection : System.Collections.ReadOnlyCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public ComponentCollection(IComponent[] components) {}

	// Methods
	public void CopyTo(IComponent[] array, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public IComponent Item { get{} }
	public IComponent Item { get{} }
	public int Count { get{} }
}

