public class Environment
{

	// Methods
	public static void FailFast(string message) {}
	public static string[] GetCommandLineArgs() {}
	public static string GetEnvironmentVariable(string variable) {}
	public static System.Collections.IDictionary GetEnvironmentVariables() {}
	public static string GetFolderPath(SpecialFolder folder) {}
	public static void Exit(int exitCode) {}
	public static string ExpandEnvironmentVariables(string name) {}
	public static string GetEnvironmentVariable(string variable, EnvironmentVariableTarget target) {}
	public static System.Collections.IDictionary GetEnvironmentVariables(EnvironmentVariableTarget target) {}
	public static void SetEnvironmentVariable(string variable, string value) {}
	public static void SetEnvironmentVariable(string variable, string value, EnvironmentVariableTarget target) {}
	public static string[] GetLogicalDrives() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int TickCount { get{} }
	public int ExitCode { get{} set{} }
	public string CommandLine { get{} }
	public string CurrentDirectory { get{} set{} }
	public string SystemDirectory { get{} }
	public string MachineName { get{} }
	public int ProcessorCount { get{} }
	public string NewLine { get{} }
	public Version Version { get{} }
	public long WorkingSet { get{} }
	public OperatingSystem OSVersion { get{} }
	public string StackTrace { get{} }
	public bool HasShutdownStarted { get{} }
	public string UserName { get{} }
	public bool UserInteractive { get{} }
	public string UserDomainName { get{} }
}

