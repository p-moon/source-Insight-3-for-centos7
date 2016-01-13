public class CookieCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public CookieCollection() {}

	// Methods
	public void Add(Cookie cookie) {}
	public void Add(CookieCollection cookies) {}
	public virtual void CopyTo(System.Array array, int index) {}
	public void CopyTo(Cookie[] array, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsReadOnly { get{} }
	public Cookie Item { get{} }
	public Cookie Item { get{} }
	public int Count { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
}

