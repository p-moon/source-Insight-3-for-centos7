public class AuthenticationManager
{

	// Methods
	public static Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials) {}
	public static Authorization PreAuthenticate(WebRequest request, ICredentials credentials) {}
	public static void Register(IAuthenticationModule authenticationModule) {}
	public static void Unregister(IAuthenticationModule authenticationModule) {}
	public static void Unregister(string authenticationScheme) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ICredentialPolicy CredentialPolicy { get{} set{} }
	public System.Collections.Specialized.StringDictionary CustomTargetNameDictionary { get{} }
	public System.Collections.IEnumerator RegisteredModules { get{} }
}

