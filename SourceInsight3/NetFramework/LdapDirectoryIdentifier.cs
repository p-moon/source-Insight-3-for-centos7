public class LdapDirectoryIdentifier : DirectoryIdentifier
{

	// Constructors
	public LdapDirectoryIdentifier(string server) {}
	public LdapDirectoryIdentifier(string server, int portNumber) {}
	public LdapDirectoryIdentifier(string server, bool fullyQualifiedDnsHostName, bool connectionless) {}
	public LdapDirectoryIdentifier(string server, int portNumber, bool fullyQualifiedDnsHostName, bool connectionless) {}
	public LdapDirectoryIdentifier(string[] servers, bool fullyQualifiedDnsHostName, bool connectionless) {}
	public LdapDirectoryIdentifier(string[] servers, int portNumber, bool fullyQualifiedDnsHostName, bool connectionless) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string[] Servers { get{} }
	public bool Connectionless { get{} }
	public bool FullyQualifiedDnsHostName { get{} }
	public int PortNumber { get{} }
}

