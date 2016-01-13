public class ServicePoint
{

	// Methods
	public bool CloseConnectionGroup(string connectionGroupName) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public BindIPEndPoint BindIPEndPointDelegate { get{} set{} }
	public int ConnectionLeaseTimeout { get{} set{} }
	public System.Uri Address { get{} }
	public int MaxIdleTime { get{} set{} }
	public bool UseNagleAlgorithm { get{} set{} }
	public int ReceiveBufferSize { get{} set{} }
	public bool Expect100Continue { get{} set{} }
	public System.DateTime IdleSince { get{} }
	public System.Version ProtocolVersion { get{} }
	public string ConnectionName { get{} }
	public int ConnectionLimit { get{} set{} }
	public int CurrentConnections { get{} }
	public System.Security.Cryptography.X509Certificates.X509Certificate Certificate { get{} }
	public System.Security.Cryptography.X509Certificates.X509Certificate ClientCertificate { get{} }
	public bool SupportsPipelining { get{} }
}

