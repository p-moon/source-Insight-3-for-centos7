public class TopLevelNameCollection : System.Collections.ReadOnlyCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public bool Contains(TopLevelName name) {}
	public int IndexOf(TopLevelName name) {}
	public void CopyTo(TopLevelName[] names, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public TopLevelName Item { get{} }
	public int Count { get{} }
}

