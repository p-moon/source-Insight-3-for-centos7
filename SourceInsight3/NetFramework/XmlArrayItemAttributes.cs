public class XmlArrayItemAttributes : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public XmlArrayItemAttributes() {}

	// Methods
	public int Add(XmlArrayItemAttribute attribute) {}
	public void Insert(int index, XmlArrayItemAttribute attribute) {}
	public int IndexOf(XmlArrayItemAttribute attribute) {}
	public bool Contains(XmlArrayItemAttribute attribute) {}
	public void Remove(XmlArrayItemAttribute attribute) {}
	public void CopyTo(XmlArrayItemAttribute[] array, int index) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public XmlArrayItemAttribute Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}

