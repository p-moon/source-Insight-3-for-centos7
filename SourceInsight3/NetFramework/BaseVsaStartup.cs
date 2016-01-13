public class BaseVsaStartup
{

	// Methods
	public void SetSite(IVsaSite site) {}
	public abstract virtual void Startup() {}
	public abstract virtual void Shutdown() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

