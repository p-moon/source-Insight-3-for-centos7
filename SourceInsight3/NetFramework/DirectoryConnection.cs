public class DirectoryConnection
{

	// Methods
	public abstract virtual DirectoryResponse SendRequest(DirectoryRequest request) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DirectoryIdentifier Directory { get{} }
	public System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get{} }
	public System.TimeSpan Timeout { get{} set{} }
	public System.Net.NetworkCredential Credential { set{} }
}

