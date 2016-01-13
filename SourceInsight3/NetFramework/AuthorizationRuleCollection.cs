public class AuthorizationRuleCollection : System.Configuration.ConfigurationElementCollection, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public AuthorizationRuleCollection() {}

	// Methods
	public void Add(AuthorizationRule rule) {}
	public void Clear() {}
	public AuthorizationRule Get(int index) {}
	public void RemoveAt(int index) {}
	public void Set(int index, AuthorizationRule rule) {}
	public int IndexOf(AuthorizationRule rule) {}
	public void Remove(AuthorizationRule rule) {}
	public virtual bool IsReadOnly() {}
	public virtual bool Equals(object compareTo) {}
	public virtual int GetHashCode() {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public void CopyTo(System.Configuration.ConfigurationElement[] array, int index) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public AuthorizationRule Item { get{} set{} }
	public System.Configuration.ConfigurationElementCollectionType CollectionType { get{} }
	public int Count { get{} }
	public bool EmitClear { get{} set{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
	public System.Configuration.ConfigurationLockCollection LockAttributes { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public System.Configuration.ConfigurationLockCollection LockElements { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public System.Configuration.ElementInformation ElementInformation { get{} }
}

