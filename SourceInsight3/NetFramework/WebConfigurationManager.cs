public class WebConfigurationManager
{

	// Methods
	public static object GetSection(string sectionName) {}
	public static object GetSection(string sectionName, string path) {}
	public static object GetWebApplicationSection(string sectionName) {}
	public static System.Configuration.Configuration OpenMachineConfiguration() {}
	public static System.Configuration.Configuration OpenMachineConfiguration(string locationSubPath) {}
	public static System.Configuration.Configuration OpenMachineConfiguration(string locationSubPath, string server) {}
	public static System.Configuration.Configuration OpenMachineConfiguration(string locationSubPath, string server, string userName, string password) {}
	public static System.Configuration.Configuration OpenMachineConfiguration(string locationSubPath, string server, System.IntPtr userToken) {}
	public static System.Configuration.Configuration OpenMappedMachineConfiguration(System.Configuration.ConfigurationFileMap fileMap) {}
	public static System.Configuration.Configuration OpenMappedMachineConfiguration(System.Configuration.ConfigurationFileMap fileMap, string locationSubPath) {}
	public static System.Configuration.Configuration OpenWebConfiguration(string path) {}
	public static System.Configuration.Configuration OpenWebConfiguration(string path, string site) {}
	public static System.Configuration.Configuration OpenWebConfiguration(string path, string site, string locationSubPath) {}
	public static System.Configuration.Configuration OpenWebConfiguration(string path, string site, string locationSubPath, string server) {}
	public static System.Configuration.Configuration OpenWebConfiguration(string path, string site, string locationSubPath, string server, string userName, string password) {}
	public static System.Configuration.Configuration OpenWebConfiguration(string path, string site, string locationSubPath, string server, System.IntPtr userToken) {}
	public static System.Configuration.Configuration OpenMappedWebConfiguration(WebConfigurationFileMap fileMap, string path) {}
	public static System.Configuration.Configuration OpenMappedWebConfiguration(WebConfigurationFileMap fileMap, string path, string site) {}
	public static System.Configuration.Configuration OpenMappedWebConfiguration(WebConfigurationFileMap fileMap, string path, string site, string locationSubPath) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Collections.Specialized.NameValueCollection AppSettings { get{} }
	public System.Configuration.ConnectionStringSettingsCollection ConnectionStrings { get{} }
}

