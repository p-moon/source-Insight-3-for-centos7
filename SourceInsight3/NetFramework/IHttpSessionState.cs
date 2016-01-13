public interface IHttpSessionState
{

	// Methods
	public abstract virtual void Abandon() {}
	public abstract virtual void Add(string name, object value) {}
	public abstract virtual void Remove(string name) {}
	public abstract virtual void RemoveAt(int index) {}
	public abstract virtual void Clear() {}
	public abstract virtual void RemoveAll() {}
	public abstract virtual System.Collections.IEnumerator GetEnumerator() {}
	public abstract virtual void CopyTo(System.Array array, int index) {}

	// Properties
	public string SessionID { get{} }
	public int Timeout { get{} set{} }
	public bool IsNewSession { get{} }
	public SessionStateMode Mode { get{} }
	public bool IsCookieless { get{} }
	public System.Web.HttpCookieMode CookieMode { get{} }
	public int LCID { get{} set{} }
	public int CodePage { get{} set{} }
	public System.Web.HttpStaticObjectsCollection StaticObjects { get{} }
	public object Item { get{} set{} }
	public object Item { get{} set{} }
	public int Count { get{} }
	public System.Collections.Specialized.NameObjectCollectionBase.KeysCollection Keys { get{} }
	public object SyncRoot { get{} }
	public bool IsReadOnly { get{} }
	public bool IsSynchronized { get{} }
}

