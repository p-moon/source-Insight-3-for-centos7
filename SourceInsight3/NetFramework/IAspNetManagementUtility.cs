public interface IAspNetManagementUtility
{

	// Methods
	public abstract virtual void DisplayAspNetConfigSettings(string machineName, string site, string virtualDirectory, string siteName, string location, int processIDout , System.String& exception) {}
	public abstract virtual void AcquireVersionList(out System.String& versionList, int versionFirst) {}
	public abstract virtual void IsRemoteConfigured(out System.Int32& isRemoteConfigured) {}
	public abstract virtual void ReadFileDates(string filenameout , System.String& creationDateout , System.String& modifiedDateout , System.String& lastAccessDate) {}
	public abstract virtual void PathIsDirectory(string filenameout , System.Int32& result) {}
	public abstract virtual void ChangeScriptMap(string keyPath, string dllInstall, int flags) {}
	public abstract virtual void RegisterAsnetMmcAssembly(int doReg, string assemblyName, string binaryDirectoryout , System.IntPtr& exception) {}
}

