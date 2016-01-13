public class DesigntimeLicenseContext : System.ComponentModel.LicenseContext, System.IServiceProvider
{

	// Constructors
	public DesigntimeLicenseContext() {}

	// Methods
	public virtual string GetSavedLicenseKey(Type type, System.Reflection.Assembly resourceAssembly) {}
	public virtual void SetSavedLicenseKey(Type type, string key) {}
	public virtual object GetService(Type type) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.ComponentModel.LicenseUsageMode UsageMode { get{} }
}

