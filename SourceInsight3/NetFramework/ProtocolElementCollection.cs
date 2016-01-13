public class ProtocolElementCollection : System.Configuration.ConfigurationElementCollection, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public ProtocolElementCollection() {}

	// Methods
	public void Add(ProtocolElement element) {}
	public void Clear() {}
	public bool ContainsKey(object key) {}
	public void CopyTo(ProtocolElement[] array, int index) {}
	public int IndexOf(ProtocolElement element) {}
	public void Remove(ProtocolElement element) {}
	public void RemoveAt(object key) {}
	public void RemoveAt(int index) {}
	public virtual bool IsReadOnly() {}
	public virtual bool Equals(object compareTo) {}
	public virtual int GetHashCode() {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public void CopyTo(System.Configuration.ConfigurationElement[] array, int index) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public ProtocolElement Item { get{} set{} }
	public ProtocolElement Item { get{} set{} }
	public int Count { get{} }
	public bool EmitClear { get{} set{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
	public System.Configuration.ConfigurationElementCollectionType CollectionType { get{} }
	public System.Configuration.ConfigurationLockCollection LockAttributes { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public System.Configuration.ConfigurationLockCollection LockElements { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public System.Configuration.ElementInformation ElementInformation { get{} }
}

