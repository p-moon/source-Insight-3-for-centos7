public class RegistryProxy
{

	// Methods
	public object GetValue(string keyName, string valueName, object defaultValue) {}
	public void SetValue(string keyName, string valueName, object value) {}
	public void SetValue(string keyName, string valueName, object value, Microsoft.Win32.RegistryValueKind valueKind) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Microsoft.Win32.RegistryKey CurrentUser { get{} }
	public Microsoft.Win32.RegistryKey LocalMachine { get{} }
	public Microsoft.Win32.RegistryKey ClassesRoot { get{} }
	public Microsoft.Win32.RegistryKey Users { get{} }
	public Microsoft.Win32.RegistryKey PerformanceData { get{} }
	public Microsoft.Win32.RegistryKey CurrentConfig { get{} }
	public Microsoft.Win32.RegistryKey DynData { get{} }
}

