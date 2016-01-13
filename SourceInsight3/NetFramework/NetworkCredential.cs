public class NetworkCredential : ICredentials, ICredentialsByHost
{

	// Constructors
	public NetworkCredential() {}
	public NetworkCredential(string userName, string password) {}
	public NetworkCredential(string userName, string password, string domain) {}

	// Methods
	public virtual NetworkCredential GetCredential(System.Uri uri, string authType) {}
	public virtual NetworkCredential GetCredential(string host, int port, string authenticationType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string UserName { get{} set{} }
	public string Password { get{} set{} }
	public string Domain { get{} set{} }
}

