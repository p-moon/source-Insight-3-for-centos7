public class LicenseProvider
{

	// Methods
	public abstract virtual License GetLicense(LicenseContext context, Type type, object instance, bool allowExceptions) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

