public class DirectoryEntry : System.ComponentModel.Component, System.ComponentModel.IComponent, System.IDisposable
{

	// Constructors
	public DirectoryEntry() {}
	public DirectoryEntry(string path) {}
	public DirectoryEntry(string path, string username, string password) {}
	public DirectoryEntry(string path, string username, string password, AuthenticationTypes authenticationType) {}
	public DirectoryEntry(object adsObject) {}

	// Methods
	public void Close() {}
	public void CommitChanges() {}
	public DirectoryEntry CopyTo(DirectoryEntry newParent) {}
	public DirectoryEntry CopyTo(DirectoryEntry newParent, string newName) {}
	public void DeleteTree() {}
	public static bool Exists(string path) {}
	public object Invoke(string methodName, object[] args) {}
	public object InvokeGet(string propertyName) {}
	public void InvokeSet(string propertyName, object[] args) {}
	public void MoveTo(DirectoryEntry newParent) {}
	public void MoveTo(DirectoryEntry newParent, string newName) {}
	public void RefreshCache() {}
	public void RefreshCache(string[] propertyNames) {}
	public void Rename(string newName) {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public AuthenticationTypes AuthenticationType { get{} set{} }
	public DirectoryEntries Children { get{} }
	public System.Guid Guid { get{} }
	public ActiveDirectorySecurity ObjectSecurity { get{} set{} }
	public string Name { get{} }
	public string NativeGuid { get{} }
	public object NativeObject { get{} }
	public DirectoryEntry Parent { get{} }
	public string Password { set{} }
	public string Path { get{} set{} }
	public PropertyCollection Properties { get{} }
	public string SchemaClassName { get{} }
	public DirectoryEntry SchemaEntry { get{} }
	public bool UsePropertyCache { get{} set{} }
	public string Username { get{} set{} }
	public DirectoryEntryConfiguration Options { get{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler Disposed;
}

