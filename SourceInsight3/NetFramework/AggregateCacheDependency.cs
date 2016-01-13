public class AggregateCacheDependency : CacheDependency, System.IDisposable, ICacheDependencyChanged
{

	// Constructors
	public AggregateCacheDependency() {}

	// Methods
	public void Add(CacheDependency[] dependencies) {}
	public virtual string GetUniqueID() {}
	public virtual void Dispose() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool HasChanged { get{} }
	public System.DateTime UtcLastModified { get{} }
}

