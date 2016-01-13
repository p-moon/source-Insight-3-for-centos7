public class WebResponse : System.MarshalByRefObject, System.Runtime.Serialization.ISerializable, System.IDisposable
{

	// Methods
	public virtual void Close() {}
	public virtual System.IO.Stream GetResponseStream() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsFromCache { get{} }
	public bool IsMutuallyAuthenticated { get{} }
	public long ContentLength { get{} set{} }
	public string ContentType { get{} set{} }
	public System.Uri ResponseUri { get{} }
	public WebHeaderCollection Headers { get{} }
}

