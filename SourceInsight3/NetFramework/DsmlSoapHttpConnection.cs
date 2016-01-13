public class DsmlSoapHttpConnection : DsmlSoapConnection
{

	// Constructors
	public DsmlSoapHttpConnection(System.Uri uri) {}
	public DsmlSoapHttpConnection(DsmlDirectoryIdentifier identifier) {}
	public DsmlSoapHttpConnection(DsmlDirectoryIdentifier identifier, System.Net.NetworkCredential credential) {}
	public DsmlSoapHttpConnection(DsmlDirectoryIdentifier identifier, System.Net.NetworkCredential credential, AuthType authType) {}

	// Methods
	public virtual void BeginSession() {}
	public virtual void EndSession() {}
	public virtual DirectoryResponse SendRequest(DirectoryRequest request) {}
	public DsmlResponseDocument SendRequest(DsmlRequestDocument request) {}
	public System.IAsyncResult BeginSendRequest(DsmlRequestDocument request, System.AsyncCallback callback, object state) {}
	public void Abort(System.IAsyncResult asyncResult) {}
	public DsmlResponseDocument EndSendRequest(System.IAsyncResult asyncResult) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.TimeSpan Timeout { get{} set{} }
	public string SoapActionHeader { get{} set{} }
	public AuthType AuthType { get{} set{} }
	public string SessionId { get{} }
	public System.Xml.XmlNode SoapRequestHeader { get{} set{} }
	public DirectoryIdentifier Directory { get{} }
	public System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get{} }
	public System.Net.NetworkCredential Credential { set{} }
}

