public class DirectoryAttributeModification : DirectoryAttribute, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public DirectoryAttributeModification() {}

	// Methods
	public object[] GetValues(Type valuesType) {}
	public int Add(byte[] value) {}
	public int Add(string value) {}
	public int Add(System.Uri value) {}
	public void AddRange(object[] values) {}
	public bool Contains(object value) {}
	public void CopyTo(object[] array, int index) {}
	public int IndexOf(object value) {}
	public void Insert(int index, byte[] value) {}
	public void Insert(int index, string value) {}
	public void Insert(int index, System.Uri value) {}
	public void Remove(object value) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DirectoryAttributeOperation Operation { get{} set{} }
	public string Name { get{} set{} }
	public object Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}

