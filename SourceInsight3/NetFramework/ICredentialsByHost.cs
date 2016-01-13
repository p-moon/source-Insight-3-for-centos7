public interface ICredentialsByHost
{

	// Methods
	public abstract virtual NetworkCredential GetCredential(string host, int port, string authenticationType) {}
}

