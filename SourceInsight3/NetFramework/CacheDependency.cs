public class CacheDependency : System.IDisposable
{

	// Constructors
	public CacheDependency(string filename) {}
	public CacheDependency(string filename, System.DateTime start) {}
	public CacheDependency(string[] filenames) {}
	public CacheDependency(string[] filenames, System.DateTime start) {}
	public CacheDependency(string[] filenames, string[] cachekeys) {}
	public CacheDependency(string[] filenames, string[] cachekeys, System.DateTime start) {}
	public CacheDependency(string[] filenames, string[] cachekeys, CacheDependency dependency) {}
	public CacheDependency(string[] filenames, string[] cachekeys, CacheDependency dependency, System.DateTime start) {}

	// Methods
	public virtual void Dispose() {}
	public virtual string GetUniqueID() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool HasChanged { get{} }
	public System.DateTime UtcLastModified { get{} }
}

