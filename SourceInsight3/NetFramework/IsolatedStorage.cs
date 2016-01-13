public class IsolatedStorage : System.MarshalByRefObject
{

	// Methods
	public abstract virtual void Remove() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ulong MaximumSize { get{} }
	public ulong CurrentSize { get{} }
	public object DomainIdentity { get{} }
	public object ApplicationIdentity { get{} }
	public object AssemblyIdentity { get{} }
	public IsolatedStorageScope Scope { get{} }
}

