public class PropertyDescriptorCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IDictionary
{

	// Constructors
	public PropertyDescriptorCollection(PropertyDescriptor[] properties) {}
	public PropertyDescriptorCollection(PropertyDescriptor[] properties, bool readOnly) {}

	// Methods
	public int Add(PropertyDescriptor value) {}
	public void Clear() {}
	public bool Contains(PropertyDescriptor value) {}
	public virtual void CopyTo(System.Array array, int index) {}
	public virtual PropertyDescriptor Find(string name, bool ignoreCase) {}
	public int IndexOf(PropertyDescriptor value) {}
	public void Insert(int index, PropertyDescriptor value) {}
	public void Remove(PropertyDescriptor value) {}
	public void RemoveAt(int index) {}
	public virtual PropertyDescriptorCollection Sort() {}
	public virtual PropertyDescriptorCollection Sort(string[] names) {}
	public virtual PropertyDescriptorCollection Sort(string[] names, System.Collections.IComparer comparer) {}
	public virtual PropertyDescriptorCollection Sort(System.Collections.IComparer comparer) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public PropertyDescriptorCollection Empty;

	// Properties
	public int Count { get{} }
	public PropertyDescriptor Item { get{} }
	public PropertyDescriptor Item { get{} }
}

