public class InstallContext
{

	// Constructors
	public InstallContext() {}
	public InstallContext(string logFilePath, string[] commandLine) {}

	// Methods
	public bool IsParameterTrue(string paramName) {}
	public void LogMessage(string message) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Collections.Specialized.StringDictionary Parameters { get{} }
}

