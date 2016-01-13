public class ToolboxItemCollection : System.Collections.ReadOnlyCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public ToolboxItemCollection(ToolboxItemCollection value) {}
	public ToolboxItemCollection(ToolboxItem[] value) {}

	// Methods
	public bool Contains(ToolboxItem value) {}
	public void CopyTo(ToolboxItem[] array, int index) {}
	public int IndexOf(ToolboxItem value) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ToolboxItem Item { get{} }
	public int Count { get{} }
}

