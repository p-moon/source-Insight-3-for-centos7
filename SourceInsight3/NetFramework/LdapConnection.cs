public class LdapConnection : DirectoryConnection, System.IDisposable
{

	// Constructors
	public LdapConnection(string server) {}
	public LdapConnection(LdapDirectoryIdentifier identifier) {}
	public LdapConnection(LdapDirectoryIdentifier identifier, System.Net.NetworkCredential credential) {}
	public LdapConnection(LdapDirectoryIdentifier identifier, System.Net.NetworkCredential credential, AuthType authType) {}

	// Methods
	public virtual DirectoryResponse SendRequest(DirectoryRequest request) {}
	public DirectoryResponse SendRequest(DirectoryRequest request, System.TimeSpan requestTimeout) {}
	public System.IAsyncResult BeginSendRequest(DirectoryRequest request, PartialResultProcessing partialMode, System.AsyncCallback callback, object state) {}
	public System.IAsyncResult BeginSendRequest(DirectoryRequest request, System.TimeSpan requestTimeout, PartialResultProcessing partialMode, System.AsyncCallback callback, object state) {}
	public void Abort(System.IAsyncResult asyncResult) {}
	public PartialResultsCollection GetPartialResults(System.IAsyncResult asyncResult) {}
	public DirectoryResponse EndSendRequest(System.IAsyncResult asyncResult) {}
	public void Bind() {}
	public void Bind(System.Net.NetworkCredential newCredential) {}
	public virtual void Dispose() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.TimeSpan Timeout { get{} set{} }
	public AuthType AuthType { get{} set{} }
	public LdapSessionOptions SessionOptions { get{} }
	public System.Net.NetworkCredential Credential { set{} }
	public bool AutoBind { get{} set{} }
	public DirectoryIdentifier Directory { get{} }
	public System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get{} }
}

