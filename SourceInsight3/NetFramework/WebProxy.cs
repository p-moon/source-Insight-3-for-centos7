public class WebProxy : IAutoWebProxy, IWebProxy, System.Runtime.Serialization.ISerializable
{

	// Constructors
	public WebProxy() {}
	public WebProxy(System.Uri Address) {}
	public WebProxy(System.Uri Address, bool BypassOnLocal) {}
	public WebProxy(System.Uri Address, bool BypassOnLocal, string[] BypassList) {}
	public WebProxy(System.Uri Address, bool BypassOnLocal, string[] BypassList, ICredentials Credentials) {}
	public WebProxy(string Host, int Port) {}
	public WebProxy(string Address) {}
	public WebProxy(string Address, bool BypassOnLocal) {}
	public WebProxy(string Address, bool BypassOnLocal, string[] BypassList) {}
	public WebProxy(string Address, bool BypassOnLocal, string[] BypassList, ICredentials Credentials) {}

	// Methods
	public virtual System.Uri GetProxy(System.Uri destination) {}
	public virtual bool IsBypassed(System.Uri host) {}
	public static WebProxy GetDefaultProxy() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Uri Address { get{} set{} }
	public bool BypassProxyOnLocal { get{} set{} }
	public string[] BypassList { get{} set{} }
	public ICredentials Credentials { get{} set{} }
	public bool UseDefaultCredentials { get{} set{} }
	public System.Collections.ArrayList BypassArrayList { get{} }
}

