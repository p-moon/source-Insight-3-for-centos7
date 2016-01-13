public class ISAPIRuntime : System.MarshalByRefObject, IISAPIRuntime, IRegisteredObject
{

	// Constructors
	public ISAPIRuntime() {}

	// Methods
	public virtual object InitializeLifetimeService() {}
	public virtual void StartProcessing() {}
	public virtual void StopProcessing() {}
	public virtual int ProcessRequest(System.IntPtr ecb, int iWRType) {}
	public virtual void DoGCCollect() {}
	public virtual object GetLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

