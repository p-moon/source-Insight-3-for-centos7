public class CommaDelimitedStringCollection : System.Collections.Specialized.StringCollection, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public CommaDelimitedStringCollection() {}

	// Methods
	public virtual string ToString() {}
	public void SetReadOnly() {}
	public void Add(string value) {}
	public void AddRange(string[] range) {}
	public void Clear() {}
	public void Insert(int index, string value) {}
	public void Remove(string value) {}
	public CommaDelimitedStringCollection Clone() {}
	public System.Collections.Specialized.StringEnumerator GetEnumerator() {}
	public int Add(string value) {}
	public void AddRange(string[] value) {}
	public virtual void Clear() {}
	public bool Contains(string value) {}
	public void CopyTo(string[] array, int index) {}
	public int IndexOf(string value) {}
	public void Insert(int index, string value) {}
	public void Remove(string value) {}
	public virtual void RemoveAt(int index) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsModified { get{} }
	public bool IsReadOnly { get{} }
	public string Item { get{} set{} }
	public int Count { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
}

