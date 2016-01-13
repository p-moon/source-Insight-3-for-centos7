public class HttpListenerPrefixCollection : ICollection<string>, IEnumerable<string>, System.Collections.IEnumerable
{

	// Methods
	public void CopyTo(System.Array array, int offset) {}
	public virtual void CopyTo(string[] array, int offset) {}
	public virtual void Add(string uriPrefix) {}
	public virtual bool Contains(string uriPrefix) {}
	public virtual IEnumerator<string> GetEnumerator() {}
	public virtual bool Remove(string uriPrefix) {}
	public virtual void Clear() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public bool IsSynchronized { get{} }
	public bool IsReadOnly { get{} }
}

