public class IntranetZoneCredentialPolicy : System.Net.ICredentialPolicy
{

	// Constructors
	public IntranetZoneCredentialPolicy() {}

	// Methods
	public virtual bool ShouldSendCredential(System.Uri challengeUri, System.Net.WebRequest request, System.Net.NetworkCredential credential, System.Net.IAuthenticationModule authModule) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

