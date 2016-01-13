public class ComManagedImportUtil : IComManagedImportUtil
{

	// Constructors
	public ComManagedImportUtil() {}

	// Methods
	public virtual void GetComponentInfo(string assemblyPathout , System.String& numComponentsout , System.String& componentInfo) {}
	public virtual void InstallAssembly(string asmpath, string parname, string appname) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

