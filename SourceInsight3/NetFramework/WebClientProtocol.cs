public class WebClientProtocol : System.ComponentModel.Component, System.ComponentModel.IComponent, System.IDisposable
{

	// Methods
	public virtual void Abort() {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Net.ICredentials Credentials { get{} set{} }
	public bool UseDefaultCredentials { get{} set{} }
	public string ConnectionGroupName { get{} set{} }
	public bool PreAuthenticate { get{} set{} }
	public string Url { get{} set{} }
	public System.Text.Encoding RequestEncoding { get{} set{} }
	public int Timeout { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler Disposed;
}

