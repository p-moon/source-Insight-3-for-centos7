public class ObjectCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public ObjectCollection(DataGridViewComboBoxCell owner) {}

	// Methods
	public int Add(object item) {}
	public void AddRange(object[] items) {}
	public void AddRange(ObjectCollection value) {}
	public virtual void Clear() {}
	public virtual bool Contains(object value) {}
	public void CopyTo(object[] destination, int arrayIndex) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public virtual int IndexOf(object value) {}
	public virtual void Insert(int index, object item) {}
	public virtual void Remove(object value) {}
	public virtual void RemoveAt(int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public bool IsReadOnly { get{} }
	public object Item { get{} set{} }
}

