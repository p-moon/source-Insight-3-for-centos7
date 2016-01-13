public class HttpSessionState : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public void Abandon() {}
	public void Add(string name, object value) {}
	public void Remove(string name) {}
	public void RemoveAt(int index) {}
	public void Clear() {}
	public void RemoveAll() {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public virtual void CopyTo(System.Array array, int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string SessionID { get{} }
	public int Timeout { get{} set{} }
	public bool IsNewSession { get{} }
	public SessionStateMode Mode { get{} }
	public bool IsCookieless { get{} }
	public System.Web.HttpCookieMode CookieMode { get{} }
	public int LCID { get{} set{} }
	public int CodePage { get{} set{} }
	public HttpSessionState Contents { get{} }
	public System.Web.HttpStaticObjectsCollection StaticObjects { get{} }
	public object Item { get{} set{} }
	public object Item { get{} set{} }
	public int Count { get{} }
	public System.Collections.Specialized.NameObjectCollectionBase.KeysCollection Keys { get{} }
	public object SyncRoot { get{} }
	public bool IsReadOnly { get{} }
	public bool IsSynchronized { get{} }
}

