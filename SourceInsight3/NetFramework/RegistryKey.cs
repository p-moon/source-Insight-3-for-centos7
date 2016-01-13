public class RegistryKey : System.MarshalByRefObject, System.IDisposable
{

	// Methods
	public void Close() {}
	public RegistryKey OpenSubKey(string name, bool writable) {}
	public RegistryKey OpenSubKey(string name) {}
	public string[] GetSubKeyNames() {}
	public object GetValue(string name) {}
	public object GetValue(string name, object defaultValue) {}
	public void Flush() {}
	public RegistryKey CreateSubKey(string subkey) {}
	public RegistryKey CreateSubKey(string subkey, RegistryKeyPermissionCheck permissionCheck) {}
	public RegistryKey CreateSubKey(string subkey, RegistryKeyPermissionCheck permissionCheck, System.Security.AccessControl.RegistrySecurity registrySecurity) {}
	public void DeleteSubKey(string subkey) {}
	public void DeleteSubKey(string subkey, bool throwOnMissingSubKey) {}
	public void DeleteSubKeyTree(string subkey) {}
	public void DeleteValue(string name) {}
	public void DeleteValue(string name, bool throwOnMissingValue) {}
	public static RegistryKey OpenRemoteBaseKey(RegistryHive hKey, string machineName) {}
	public RegistryKey OpenSubKey(string name, RegistryKeyPermissionCheck permissionCheck) {}
	public RegistryKey OpenSubKey(string name, RegistryKeyPermissionCheck permissionCheck, System.Security.AccessControl.RegistryRights rights) {}
	public string[] GetValueNames() {}
	public object GetValue(string name, object defaultValue, RegistryValueOptions options) {}
	public RegistryValueKind GetValueKind(string name) {}
	public void SetValue(string name, object value) {}
	public void SetValue(string name, object value, RegistryValueKind valueKind) {}
	public virtual string ToString() {}
	public System.Security.AccessControl.RegistrySecurity GetAccessControl() {}
	public System.Security.AccessControl.RegistrySecurity GetAccessControl(System.Security.AccessControl.AccessControlSections includeSections) {}
	public void SetAccessControl(System.Security.AccessControl.RegistrySecurity registrySecurity) {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int SubKeyCount { get{} }
	public int ValueCount { get{} }
	public string Name { get{} }
}

