public interface IRegiisUtility
{

	// Methods
	public abstract virtual void ProtectedConfigAction(long actionToPerform, string firstArgument, string secondArgument, string providerName, string appPath, string site, string cspOrLocation, int keySizeout , System.IntPtr& exception) {}
	public abstract virtual void RegisterSystemWebAssembly(int doRegout , System.IntPtr& exception) {}
	public abstract virtual void RegisterAsnetMmcAssembly(int doReg, string assemblyName, string binaryDirectoryout , System.IntPtr& exception) {}
	public abstract virtual void RemoveBrowserCaps(out System.IntPtr& exception) {}
}

