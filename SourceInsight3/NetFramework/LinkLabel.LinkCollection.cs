public class LinkCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public LinkCollection(LinkLabel owner) {}

	// Methods
	public Link Add(int start, int length) {}
	public Link Add(int start, int length, object linkData) {}
	public int Add(Link value) {}
	public bool Contains(Link link) {}
	public virtual bool ContainsKey(string key) {}
	public int IndexOf(Link link) {}
	public virtual int IndexOfKey(string key) {}
	public virtual void Clear() {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public void Remove(Link value) {}
	public virtual void RemoveAt(int index) {}
	public virtual void RemoveByKey(string key) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Link Item { get{} set{} }
	public Link Item { get{} }
	public int Count { get{} }
	public bool LinksAdded { get{} }
	public bool IsReadOnly { get{} }
}

