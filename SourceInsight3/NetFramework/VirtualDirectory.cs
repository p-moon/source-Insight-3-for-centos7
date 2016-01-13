public class VirtualDirectory : VirtualFileBase
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
	public bool IsDirectory { get{} }
	public System.Collections.IEnumerable Directories { get{} }
	public System.Collections.IEnumerable Files { get{} }
	public System.Collections.IEnumerable Children { get{} }
	public string Name { get{} }
	public string VirtualPath { get{} }
}

