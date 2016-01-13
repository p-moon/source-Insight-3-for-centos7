public class ToolLocationHelper
{

	// Methods
	public static string GetDotNetFrameworkVersionFolderPrefix(TargetDotNetFrameworkVersion version) {}
	public static string GetDotNetFrameworkRootRegistryKey(TargetDotNetFrameworkVersion version) {}
	public static string GetDotNetFrameworkSdkInstallKeyValue(TargetDotNetFrameworkVersion version) {}
	public static string GetPathToDotNetFramework(TargetDotNetFrameworkVersion version) {}
	public static string GetPathToDotNetFrameworkSdk(TargetDotNetFrameworkVersion version) {}
	public static string GetPathToDotNetFrameworkSdkFile(string fileName, TargetDotNetFrameworkVersion version) {}
	public static string GetPathToDotNetFrameworkFile(string fileName, TargetDotNetFrameworkVersion version) {}
	public static string GetPathToSystemFile(string fileName) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string PathToSystem { get{} }
}

