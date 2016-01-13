public class KeyedCollection<TKey,TItem> : Collection<TItem>, IList<TItem>, ICollection<TItem>, IEnumerable<TItem>, System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection
{

	// Methods
	public bool Contains(TKey key) {}
	public bool Remove(TKey key) {}
	public virtual void Add(TItem item) {}
	public virtual void Clear() {}
	public virtual void CopyTo(TItem[] array, int index) {}
	public virtual bool Contains(TItem item) {}
	public virtual IEnumerator<TItem> GetEnumerator() {}
	public virtual int IndexOf(TItem item) {}
	public virtual void Insert(int index, TItem item) {}
	public virtual bool Remove(TItem item) {}
	public virtual void RemoveAt(int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public IEqualityComparer<TKey> Comparer { get{} }
	public TItem Item { get{} }
	public int Count { get{} }
	public TItem Item { get{} set{} }
}

