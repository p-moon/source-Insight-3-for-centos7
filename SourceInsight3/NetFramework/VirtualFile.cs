public class VirtualFile : VirtualFileBase
{

	// Methods
	public abstract virtual System.IO.Stream Open() {}
	public virtual object InitializeLifetimeService() {}
	public virtual object GetLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsDirectory { get{} }
	public string Name { get{} }
	public string VirtualPath { get{} }
}

