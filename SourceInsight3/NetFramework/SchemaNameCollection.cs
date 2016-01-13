public class SchemaNameCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public int Add(string value) {}
	public void AddRange(string[] value) {}
	public void AddRange(SchemaNameCollection value) {}
	public virtual void Clear() {}
	public bool Contains(string value) {}
	public void CopyTo(string[] stringArray, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public int IndexOf(string value) {}
	public void Insert(int index, string value) {}
	public void Remove(string value) {}
	public virtual void RemoveAt(int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Item { get{} set{} }
	public int Count { get{} }
}

