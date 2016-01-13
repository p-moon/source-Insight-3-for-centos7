public class ConfigurationManager
{

	// Methods
	public static object GetSection(string sectionName) {}
	public static void RefreshSection(string sectionName) {}
	public static Configuration OpenMachineConfiguration() {}
	public static Configuration OpenMappedMachineConfiguration(ConfigurationFileMap fileMap) {}
	public static Configuration OpenExeConfiguration(ConfigurationUserLevel userLevel) {}
	public static Configuration OpenExeConfiguration(string exePath) {}
	public static Configuration OpenMappedExeConfiguration(ExeConfigurationFileMap fileMap, ConfigurationUserLevel userLevel) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Collections.Specialized.NameValueCollection AppSettings { get{} }
	public ConnectionStringSettingsCollection ConnectionStrings { get{} }
}

