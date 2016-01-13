public class VirtualPathProvider : System.MarshalByRefObject
{

	// Methods
	public virtual object InitializeLifetimeService() {}
	public virtual string GetFileHash(string virtualPath, System.Collections.IEnumerable virtualPathDependencies) {}
	public virtual System.Web.Caching.CacheDependency GetCacheDependency(string virtualPath, System.Collections.IEnumerable virtualPathDependencies, System.DateTime utcStart) {}
	public virtual bool FileExists(string virtualPath) {}
	public virtual bool DirectoryExists(string virtualDir) {}
	public virtual VirtualFile GetFile(string virtualPath) {}
	public virtual VirtualDirectory GetDirectory(string virtualDir) {}
	public virtual string GetCacheKey(string virtualPath) {}
	public virtual string CombineVirtualPaths(string basePath, string relativePath) {}
	public static System.IO.Stream OpenFile(string virtualPath) {}
	public virtual object GetLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

