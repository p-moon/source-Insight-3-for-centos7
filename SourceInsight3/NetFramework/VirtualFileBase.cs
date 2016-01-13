public class VirtualFileBase : System.MarshalByRefObject
{

	// Methods
	public virtual object InitializeLifetimeService() {}
	public virtual object GetLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} }
	public string VirtualPath { get{} }
	public bool IsDirectory { get{} }
}

