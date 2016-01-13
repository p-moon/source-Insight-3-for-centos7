public class ServicePointManager
{

	// Methods
	public static ServicePoint FindServicePoint(System.Uri address) {}
	public static ServicePoint FindServicePoint(string uriString, IWebProxy proxy) {}
	public static ServicePoint FindServicePoint(System.Uri address, IWebProxy proxy) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int DefaultNonPersistentConnectionLimit;
	public int DefaultPersistentConnectionLimit;

	// Properties
	public SecurityProtocolType SecurityProtocol { get{} set{} }
	public int MaxServicePoints { get{} set{} }
	public int DefaultConnectionLimit { get{} set{} }
	public int MaxServicePointIdleTime { get{} set{} }
	public bool UseNagleAlgorithm { get{} set{} }
	public bool Expect100Continue { get{} set{} }
	public bool EnableDnsRoundRobin { get{} set{} }
	public int DnsRefreshTimeout { get{} set{} }
	public ICertificatePolicy CertificatePolicy { get{} set{} }
	public System.Net.Security.RemoteCertificateValidationCallback ServerCertificateValidationCallback { get{} set{} }
	public bool CheckCertificateRevocationList { get{} set{} }
}

