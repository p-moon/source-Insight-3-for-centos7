public class RegiisUtility : IRegiisUtility
{

	// Constructors
	public RegiisUtility() {}

	// Methods
	public virtual void RegisterSystemWebAssembly(int doRegout , System.IntPtr& exception) {}
	public virtual void RegisterAsnetMmcAssembly(int doReg, string typeName, string binaryDirectoryout , System.IntPtr& exception) {}
	public virtual void ProtectedConfigAction(long options, string firstArgument, string secondArgument, string providerName, string appPath, string site, string cspOrLocation, int keySizeout , System.IntPtr& exception) {}
	public virtual void RemoveBrowserCaps(out System.IntPtr& exception) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

