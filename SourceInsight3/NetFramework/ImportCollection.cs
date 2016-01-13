public class ImportCollection : ServiceDescriptionBaseCollection, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public int Add(Import import) {}
	public void Insert(int index, Import import) {}
	public int IndexOf(Import import) {}
	public bool Contains(Import import) {}
	public void Remove(Import import) {}
	public void CopyTo(Import[] array, int index) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Import Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}

