public class StandardOleMarshalObject : System.MarshalByRefObject, Microsoft.Win32.UnsafeNativeMethods.IMarshal
{

	// Methods
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

