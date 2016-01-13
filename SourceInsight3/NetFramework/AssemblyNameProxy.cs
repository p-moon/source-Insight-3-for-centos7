public class AssemblyNameProxy : System.MarshalByRefObject
{

	// Constructors
	public AssemblyNameProxy() {}

	// Methods
	public AssemblyName GetAssemblyName(string assemblyFile) {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

