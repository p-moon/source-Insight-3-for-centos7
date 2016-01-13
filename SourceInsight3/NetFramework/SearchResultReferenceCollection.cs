public class SearchResultReferenceCollection : System.Collections.ReadOnlyCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public bool Contains(SearchResultReference value) {}
	public int IndexOf(SearchResultReference value) {}
	public void CopyTo(SearchResultReference[] values, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public SearchResultReference Item { get{} }
	public int Count { get{} }
}

