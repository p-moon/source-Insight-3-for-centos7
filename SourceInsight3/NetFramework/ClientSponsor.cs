public class ClientSponsor : System.MarshalByRefObject, ISponsor
{

	// Constructors
	public ClientSponsor() {}
	public ClientSponsor(System.TimeSpan renewalTime) {}

	// Methods
	public bool Register(System.MarshalByRefObject obj) {}
	public void Unregister(System.MarshalByRefObject obj) {}
	public virtual System.TimeSpan Renewal(ILease lease) {}
	public void Close() {}
	public virtual object InitializeLifetimeService() {}
	public virtual object GetLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.TimeSpan RenewalTime { get{} set{} }
}

