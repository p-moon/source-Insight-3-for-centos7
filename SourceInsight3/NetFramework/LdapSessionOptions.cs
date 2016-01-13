public class LdapSessionOptions
{

	// Methods
	public void FastConcurrentBind() {}
	public void StartTransportLayerSecurity(DirectoryControlCollection controls) {}
	public void StopTransportLayerSecurity() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ReferralChasingOptions ReferralChasing { get{} set{} }
	public bool SecureSocketLayer { get{} set{} }
	public int ReferralHopLimit { get{} set{} }
	public int ProtocolVersion { get{} set{} }
	public string HostName { get{} set{} }
	public string DomainName { get{} set{} }
	public LocatorFlags LocatorFlag { get{} set{} }
	public bool HostReachable { get{} }
	public System.TimeSpan PingKeepAliveTimeout { get{} set{} }
	public int PingLimit { get{} set{} }
	public System.TimeSpan PingWaitTimeout { get{} set{} }
	public bool AutoReconnect { get{} set{} }
	public int SspiFlag { get{} set{} }
	public SecurityPackageContextConnectionInformation SslInformation { get{} }
	public object SecurityContext { get{} }
	public bool Signing { get{} set{} }
	public bool Sealing { get{} set{} }
	public string SaslMethod { get{} set{} }
	public bool RootDseCache { get{} set{} }
	public bool TcpKeepAlive { get{} set{} }
	public System.TimeSpan SendTimeout { get{} set{} }
	public ReferralCallback ReferralCallback { get{} set{} }
	public QueryClientCertificateCallback QueryClientCertificate { get{} set{} }
	public VerifyServerCertificateCallback VerifyServerCertificate { get{} set{} }
}

