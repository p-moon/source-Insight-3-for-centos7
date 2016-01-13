public class PropertyValueCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public int Add(object value) {}
	public void AddRange(object[] value) {}
	public void AddRange(PropertyValueCollection value) {}
	public bool Contains(object value) {}
	public void CopyTo(object[] array, int index) {}
	public int IndexOf(object value) {}
	public void Insert(int index, object value) {}
	public void Remove(object value) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object Item { get{} set{} }
	public string PropertyName { get{} }
	public object Value { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}

