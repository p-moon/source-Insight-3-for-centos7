public class ResourceProviderFactory
{

	// Methods
	public abstract virtual IResourceProvider CreateGlobalResourceProvider(string classKey) {}
	public abstract virtual IResourceProvider CreateLocalResourceProvider(string virtualPath) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

