public class ObjectHandle : System.MarshalByRefObject, IObjectHandle
{

	// Constructors
	public ObjectHandle(object o) {}

	// Methods
	public virtual object Unwrap() {}
	public virtual object InitializeLifetimeService() {}
	public virtual object GetLifetimeService() {}
	public virtual ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

