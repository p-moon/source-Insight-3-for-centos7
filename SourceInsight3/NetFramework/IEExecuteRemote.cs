public class IEExecuteRemote : System.MarshalByRefObject
{

	// Constructors
	public IEExecuteRemote() {}

	// Methods
	public int ExecuteAsAssembly(string file, System.Security.Policy.Evidence evidence, byte[] hash, System.Configuration.Assemblies.AssemblyHashAlgorithm id) {}
	public int ExecuteAsDll(string file, System.Security.Policy.Evidence evidence, object pars) {}
	public virtual object InitializeLifetimeService() {}
	public virtual object GetLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.IO.Stream Exception { get{} }
}

