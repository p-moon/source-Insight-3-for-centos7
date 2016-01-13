public class LicenseContext : System.IServiceProvider
{

	// Constructors
	public LicenseContext() {}

	// Methods
	public virtual string GetSavedLicenseKey(Type type, System.Reflection.Assembly resourceAssembly) {}
	public virtual object GetService(Type type) {}
	public virtual void SetSavedLicenseKey(Type type, string key) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public LicenseUsageMode UsageMode { get{} }
}

