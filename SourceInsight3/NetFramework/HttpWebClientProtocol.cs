public class HttpWebClientProtocol : WebClientProtocol, System.ComponentModel.IComponent, System.IDisposable
{

	// Methods
	public static bool GenerateXmlMappings(Type type, System.Collections.ArrayList mappings) {}
	public static System.Collections.Hashtable GenerateXmlMappings(Type[] types, System.Collections.ArrayList mappings) {}
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
	public bool AllowAutoRedirect { get{} set{} }
	public System.Net.CookieContainer CookieContainer { get{} set{} }
	public System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get{} }
	public bool EnableDecompression { get{} set{} }
	public string UserAgent { get{} set{} }
	public System.Net.IWebProxy Proxy { get{} set{} }
	public bool UnsafeAuthenticatedConnectionSharing { get{} set{} }
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

