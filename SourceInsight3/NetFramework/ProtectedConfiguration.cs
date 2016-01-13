public class ProtectedConfiguration
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public string RsaProviderName;
	public string DataProtectionProviderName;
	public string ProtectedDataSectionName;

	// Properties
	public ProtectedConfigurationProviderCollection Providers { get{} }
	public string DefaultProvider { get{} }
}

