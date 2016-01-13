public class ConnectionStringSettingsCollection : ConfigurationElementCollection, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public ConnectionStringSettingsCollection() {}

	// Methods
	public int IndexOf(ConnectionStringSettings settings) {}
	public void Add(ConnectionStringSettings settings) {}
	public void Remove(ConnectionStringSettings settings) {}
	public void RemoveAt(int index) {}
	public void Remove(string name) {}
	public void Clear() {}
	public virtual bool IsReadOnly() {}
	public virtual bool Equals(object compareTo) {}
	public virtual int GetHashCode() {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public void CopyTo(ConfigurationElement[] array, int index) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public ConnectionStringSettings Item { get{} set{} }
	public ConnectionStringSettings Item { get{} }
	public int Count { get{} }
	public bool EmitClear { get{} set{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
	public ConfigurationElementCollectionType CollectionType { get{} }
	public ConfigurationLockCollection LockAttributes { get{} }
	public ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public ConfigurationLockCollection LockElements { get{} }
	public ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public ElementInformation ElementInformation { get{} }
}

