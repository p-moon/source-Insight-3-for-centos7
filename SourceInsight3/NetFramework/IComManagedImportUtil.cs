public interface IComManagedImportUtil
{

	// Methods
	public abstract virtual void GetComponentInfo(string assemblyPathout , System.String& numComponentsout , System.String& componentInfo) {}
	public abstract virtual void InstallAssembly(string filename, string parname, string appname) {}
}

