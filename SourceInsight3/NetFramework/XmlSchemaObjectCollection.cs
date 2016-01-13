public class XmlSchemaObjectCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public XmlSchemaObjectCollection() {}
	public XmlSchemaObjectCollection(XmlSchemaObject parent) {}

	// Methods
	public XmlSchemaObjectEnumerator GetEnumerator() {}
	public int Add(XmlSchemaObject item) {}
	public void Insert(int index, XmlSchemaObject item) {}
	public int IndexOf(XmlSchemaObject item) {}
	public bool Contains(XmlSchemaObject item) {}
	public void Remove(XmlSchemaObject item) {}
	public void CopyTo(XmlSchemaObject[] array, int index) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public XmlSchemaObject Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}

