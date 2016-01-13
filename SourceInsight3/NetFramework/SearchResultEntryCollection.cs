public class SearchResultEntryCollection : System.Collections.ReadOnlyCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public bool Contains(SearchResultEntry value) {}
	public int IndexOf(SearchResultEntry value) {}
	public void CopyTo(SearchResultEntry[] values, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public SearchResultEntry Item { get{} }
	public int Count { get{} }
}

