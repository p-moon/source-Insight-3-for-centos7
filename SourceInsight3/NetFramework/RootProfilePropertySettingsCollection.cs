public class RootProfilePropertySettingsCollection : ProfilePropertySettingsCollection, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public RootProfilePropertySettingsCollection() {}

	// Methods
	public virtual bool Equals(object rootProfilePropertySettingsCollection) {}
	public virtual int GetHashCode() {}
	public void Add(ProfilePropertySettings propertySettings) {}
	public ProfilePropertySettings Get(int index) {}
	public ProfilePropertySettings Get(string name) {}
	public string GetKey(int index) {}
	public void Remove(string name) {}
	public void RemoveAt(int index) {}
	public void Set(ProfilePropertySettings propertySettings) {}
	public int IndexOf(ProfilePropertySettings propertySettings) {}
	public void Clear() {}
	public virtual bool IsReadOnly() {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public void CopyTo(System.Configuration.ConfigurationElement[] array, int index) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public ProfileGroupSettingsCollection GroupSettings { get{} }
	public string[] AllKeys { get{} }
	public ProfilePropertySettings Item { get{} }
	public ProfilePropertySettings Item { get{} set{} }
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

