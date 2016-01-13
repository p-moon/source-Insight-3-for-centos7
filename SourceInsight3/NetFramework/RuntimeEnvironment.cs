public class RuntimeEnvironment
{

	// Constructors
	public RuntimeEnvironment() {}

	// Methods
	public static bool FromGlobalAccessCache(System.Reflection.Assembly a) {}
	public static string GetRuntimeDirectory() {}
	public static string GetSystemVersion() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string SystemConfigurationFile { get{} }
}

