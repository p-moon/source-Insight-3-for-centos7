public class DesignTimeResourceProviderFactory
{

	// Methods
	public abstract virtual System.Web.Compilation.IResourceProvider CreateDesignTimeGlobalResourceProvider(System.IServiceProvider serviceProvider, string classKey) {}
	public abstract virtual System.Web.Compilation.IResourceProvider CreateDesignTimeLocalResourceProvider(System.IServiceProvider serviceProvider) {}
	public abstract virtual IDesignTimeResourceWriter CreateDesignTimeLocalResourceWriter(System.IServiceProvider serviceProvider) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

