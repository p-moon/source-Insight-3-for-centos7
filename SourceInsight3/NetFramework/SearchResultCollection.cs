public class SearchResultCollection : System.MarshalByRefObject, System.Collections.ICollection, System.Collections.IEnumerable, System.IDisposable
{

	// Methods
	public virtual void Dispose() {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public bool Contains(SearchResult result) {}
	public void CopyTo(SearchResult[] results, int index) {}
	public int IndexOf(SearchResult result) {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public SearchResult Item { get{} }
	public int Count { get{} }
	public System.IntPtr Handle { get{} }
	public string[] PropertiesLoaded { get{} }
}

