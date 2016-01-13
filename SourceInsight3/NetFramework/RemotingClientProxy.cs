public class RemotingClientProxy : System.ComponentModel.Component, System.ComponentModel.IComponent, System.IDisposable
{

	// Methods
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool AllowAutoRedirect { get{} set{} }
	public object Cookies { get{} }
	public bool EnableCookies { get{} set{} }
	public bool PreAuthenticate { get{} set{} }
	public string Path { get{} set{} }
	public int Timeout { get{} set{} }
	public string Url { get{} set{} }
	public string UserAgent { get{} set{} }
	public string Username { get{} set{} }
	public string Password { get{} set{} }
	public string Domain { get{} set{} }
	public string ProxyName { get{} set{} }
	public int ProxyPort { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler Disposed;
}

