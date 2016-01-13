public class DirectorySearcher : System.ComponentModel.Component, System.ComponentModel.IComponent, System.IDisposable
{

	// Constructors
	public DirectorySearcher() {}
	public DirectorySearcher(DirectoryEntry searchRoot) {}
	public DirectorySearcher(DirectoryEntry searchRoot, string filter) {}
	public DirectorySearcher(DirectoryEntry searchRoot, string filter, string[] propertiesToLoad) {}
	public DirectorySearcher(string filter) {}
	public DirectorySearcher(string filter, string[] propertiesToLoad) {}
	public DirectorySearcher(string filter, string[] propertiesToLoad, SearchScope scope) {}
	public DirectorySearcher(DirectoryEntry searchRoot, string filter, string[] propertiesToLoad, SearchScope scope) {}

	// Methods
	public SearchResult FindOne() {}
	public SearchResultCollection FindAll() {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool CacheResults { get{} set{} }
	public System.TimeSpan ClientTimeout { get{} set{} }
	public bool PropertyNamesOnly { get{} set{} }
	public string Filter { get{} set{} }
	public int PageSize { get{} set{} }
	public System.Collections.Specialized.StringCollection PropertiesToLoad { get{} }
	public ReferralChasingOption ReferralChasing { get{} set{} }
	public SearchScope SearchScope { get{} set{} }
	public System.TimeSpan ServerPageTimeLimit { get{} set{} }
	public System.TimeSpan ServerTimeLimit { get{} set{} }
	public int SizeLimit { get{} set{} }
	public DirectoryEntry SearchRoot { get{} set{} }
	public SortOption Sort { get{} set{} }
	public bool Asynchronous { get{} set{} }
	public bool Tombstone { get{} set{} }
	public string AttributeScopeQuery { get{} set{} }
	public DereferenceAlias DerefAlias { get{} set{} }
	public SecurityMasks SecurityMasks { get{} set{} }
	public ExtendedDN ExtendedDN { get{} set{} }
	public DirectorySynchronization DirectorySynchronization { get{} set{} }
	public DirectoryVirtualListView VirtualListView { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler Disposed;
}

