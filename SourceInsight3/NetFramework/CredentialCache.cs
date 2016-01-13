public class CredentialCache : ICredentials, ICredentialsByHost, System.Collections.IEnumerable
{

	// Constructors
	public CredentialCache() {}

	// Methods
	public void Add(System.Uri uriPrefix, string authType, NetworkCredential cred) {}
	public void Add(string host, int port, string authenticationType, NetworkCredential credential) {}
	public void Remove(System.Uri uriPrefix, string authType) {}
	public void Remove(string host, int port, string authenticationType) {}
	public virtual NetworkCredential GetCredential(System.Uri uriPrefix, string authType) {}
	public virtual NetworkCredential GetCredential(string host, int port, string authenticationType) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ICredentials DefaultCredentials { get{} }
	public NetworkCredential DefaultNetworkCredentials { get{} }
}

