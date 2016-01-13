public class SoapHeaderCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public SoapHeaderCollection() {}

	// Methods
	public int Add(SoapHeader header) {}
	public void Insert(int index, SoapHeader header) {}
	public int IndexOf(SoapHeader header) {}
	public bool Contains(SoapHeader header) {}
	public void Remove(SoapHeader header) {}
	public void CopyTo(SoapHeader[] array, int index) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public SoapHeader Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}

