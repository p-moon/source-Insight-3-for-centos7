public class ConfigurationPropertyCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public ConfigurationPropertyCollection() {}

	// Methods
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public void Add(ConfigurationProperty property) {}
	public void CopyTo(ConfigurationProperty[] array, int index) {}
	public bool Contains(string name) {}
	public bool Remove(string name) {}
	public void Clear() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
	public ConfigurationProperty Item { get{} }
}

