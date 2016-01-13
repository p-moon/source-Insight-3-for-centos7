public class Ping : System.ComponentModel.Component, System.ComponentModel.IComponent, System.IDisposable
{

	// Constructors
	public Ping() {}

	// Methods
	public void SendAsyncCancel() {}
	public PingReply Send(string hostNameOrAddress) {}
	public PingReply Send(string hostNameOrAddress, int timeout) {}
	public PingReply Send(System.Net.IPAddress address) {}
	public PingReply Send(System.Net.IPAddress address, int timeout) {}
	public PingReply Send(string hostNameOrAddress, int timeout, byte[] buffer) {}
	public PingReply Send(System.Net.IPAddress address, int timeout, byte[] buffer) {}
	public PingReply Send(string hostNameOrAddress, int timeout, byte[] buffer, PingOptions options) {}
	public PingReply Send(System.Net.IPAddress address, int timeout, byte[] buffer, PingOptions options) {}
	public void SendAsync(string hostNameOrAddress, object userToken) {}
	public void SendAsync(string hostNameOrAddress, int timeout, object userToken) {}
	public void SendAsync(System.Net.IPAddress address, object userToken) {}
	public void SendAsync(System.Net.IPAddress address, int timeout, object userToken) {}
	public void SendAsync(string hostNameOrAddress, int timeout, byte[] buffer, object userToken) {}
	public void SendAsync(System.Net.IPAddress address, int timeout, byte[] buffer, object userToken) {}
	public void SendAsync(string hostNameOrAddress, int timeout, byte[] buffer, PingOptions options, object userToken) {}
	public void SendAsync(System.Net.IPAddress address, int timeout, byte[] buffer, PingOptions options, object userToken) {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.Net.NetworkInformation.PingCompletedEventHandler PingCompleted;
	public event System.EventHandler Disposed;
}

