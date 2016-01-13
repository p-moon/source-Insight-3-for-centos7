public class XmlElementAttributes : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public XmlElementAttributes() {}

	// Methods
	public int Add(XmlElementAttribute attribute) {}
	public void Insert(int index, XmlElementAttribute attribute) {}
	public int IndexOf(XmlElementAttribute attribute) {}
	public bool Contains(XmlElementAttribute attribute) {}
	public void Remove(XmlElementAttribute attribute) {}
	public void CopyTo(XmlElementAttribute[] array, int index) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public XmlElementAttribute Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}

