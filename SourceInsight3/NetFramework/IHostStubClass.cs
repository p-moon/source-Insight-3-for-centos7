public class IHostStubClass : System.__ComObject, IHostEx, IHostStub
{

	// Constructors
	public IHostStubClass() {}

	// Methods
	public virtual ISecureFactory GetSecuredClassFactory(int dwIdentityFlags, int dwZone, string lpSite, string pbSecurityId, string lpHash, string className, string fileName) {}
	public virtual ISecureFactory GetClassFactory(string className, string fileName) {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

