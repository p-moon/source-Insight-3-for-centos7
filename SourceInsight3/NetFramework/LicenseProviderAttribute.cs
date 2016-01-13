public class LicenseProviderAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public LicenseProviderAttribute() {}
	public LicenseProviderAttribute(string typeName) {}
	public LicenseProviderAttribute(Type type) {}

	// Methods
	public virtual bool Equals(object value) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public LicenseProviderAttribute Default;

	// Properties
	public Type LicenseProvider { get{} }
	public object TypeId { get{} }
}

