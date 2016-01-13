public class FileWebResponse : WebResponse, System.Runtime.Serialization.ISerializable, System.IDisposable, ICloseEx
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
	public long ContentLength { get{} }
	public string ContentType { get{} }
	public WebHeaderCollection Headers { get{} }
	public System.Uri ResponseUri { get{} }
	public bool IsFromCache { get{} }
	public bool IsMutuallyAuthenticated { get{} }
}

