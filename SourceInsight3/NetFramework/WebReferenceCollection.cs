public class WebReferenceCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public WebReferenceCollection() {}

	// Methods
	public int Add(WebReference webReference) {}
	public void Insert(int index, WebReference webReference) {}
	public int IndexOf(WebReference webReference) {}
	public bool Contains(WebReference webReference) {}
	public void Remove(WebReference webReference) {}
	public void CopyTo(WebReference[] array, int index) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public WebReference Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}

