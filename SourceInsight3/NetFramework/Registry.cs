public class Registry
{

	// Methods
	public static object GetValue(string keyName, string valueName, object defaultValue) {}
	public static void SetValue(string keyName, string valueName, object value) {}
	public static void SetValue(string keyName, string valueName, object value, RegistryValueKind valueKind) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public RegistryKey CurrentUser;
	public RegistryKey LocalMachine;
	public RegistryKey ClassesRoot;
	public RegistryKey Users;
	public RegistryKey PerformanceData;
	public RegistryKey CurrentConfig;
	public RegistryKey DynData;
}

