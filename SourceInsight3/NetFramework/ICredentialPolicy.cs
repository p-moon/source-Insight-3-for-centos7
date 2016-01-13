public interface ICredentialPolicy
{

	// Methods
	public abstract virtual bool ShouldSendCredential(System.Uri challengeUri, WebRequest request, NetworkCredential credential, IAuthenticationModule authenticationModule) {}
}

