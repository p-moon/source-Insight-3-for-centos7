public interface IAuthenticationModule
{

	// Methods
	public abstract virtual Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials) {}
	public abstract virtual Authorization PreAuthenticate(WebRequest request, ICredentials credentials) {}

	// Properties
	public bool CanPreAuthenticate { get{} }
	public string AuthenticationType { get{} }
}

