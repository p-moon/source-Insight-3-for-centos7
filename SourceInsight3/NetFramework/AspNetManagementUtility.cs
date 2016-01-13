public class AspNetManagementUtility : IAspNetManagementUtility
{

	// Constructors
	public AspNetManagementUtility() {}

	// Methods
	public static int MessageBox(System.IntPtr hWnd, string text, string caption, int type) {}
	public static System.IntPtr GetActiveWindow() {}
	public virtual void DisplayAspNetConfigSettings(string machineName, string site, string virtualDirectory, string siteName, string location, int processIDout , System.String& exception) {}
	public virtual void AcquireVersionList(out System.String& versionList, int versionFirst) {}
	public virtual void ReadFileDates(string filenameout , System.String& creationDateout , System.String& modifiedDateout , System.String& lastAccessDate) {}
	public virtual void IsRemoteConfigured(out System.Int32& isRemoteConfigured) {}
	public virtual void PathIsDirectory(string filenameout , System.Int32& result) {}
	public virtual void ChangeScriptMap(string keyPath, string dllInstall, int flags) {}
	public virtual void RegisterAsnetMmcAssembly(int doReg, string typeName, string binaryDirectoryout , System.IntPtr& exception) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

