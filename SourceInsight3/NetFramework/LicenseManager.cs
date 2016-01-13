public class LicenseManager
{

	// Methods
	public static object CreateWithContext(Type type, LicenseContext creationContext) {}
	public static object CreateWithContext(Type type, LicenseContext creationContext, object[] args) {}
	public static bool IsLicensed(Type type) {}
	public static bool IsValid(Type type) {}
	public static bool IsValid(Type type, object instanceout , License& license) {}
	public static void LockContext(object contextUser) {}
	public static void UnlockContext(object contextUser) {}
	public static void Validate(Type type) {}
	public static License Validate(Type type, object instance) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public LicenseContext CurrentContext { get{} set{} }
	public LicenseUsageMode UsageMode { get{} }
}

