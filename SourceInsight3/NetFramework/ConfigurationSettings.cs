public class ConfigurationSettings
{

	// Methods
	public static object GetConfig(string sectionName) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Collections.Specialized.NameValueCollection AppSettings { get{} }
}

