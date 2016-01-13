public class XmlAnyElementAttributes : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public XmlAnyElementAttributes() {}

	// Methods
	public int Add(XmlAnyElementAttribute attribute) {}
	public void Insert(int index, XmlAnyElementAttribute attribute) {}
	public int IndexOf(XmlAnyElementAttribute attribute) {}
	public bool Contains(XmlAnyElementAttribute attribute) {}
	public void Remove(XmlAnyElementAttribute attribute) {}
	public void CopyTo(XmlAnyElementAttribute[] array, int index) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public XmlAnyElementAttribute Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}

