public class WebPartTransformerCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public WebPartTransformerCollection() {}

	// Methods
	public int Add(WebPartTransformer transformer) {}
	public bool Contains(WebPartTransformer transformer) {}
	public void CopyTo(WebPartTransformer[] array, int index) {}
	public int IndexOf(WebPartTransformer transformer) {}
	public void Insert(int index, WebPartTransformer transformer) {}
	public void Remove(WebPartTransformer transformer) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsReadOnly { get{} }
	public WebPartTransformer Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}

