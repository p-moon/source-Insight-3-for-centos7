public class ConfigurationLockCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public void Add(string name) {}
	public void Remove(string name) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public void Clear() {}
	public bool Contains(string name) {}
	public void CopyTo(string[] array, int index) {}
	public bool IsReadOnly(string name) {}
	public void SetFromList(string attributeList) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
	public bool IsModified { get{} }
	public string AttributeList { get{} }
	public bool HasParentElements { get{} }
}

