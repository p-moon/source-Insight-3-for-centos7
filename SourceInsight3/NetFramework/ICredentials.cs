public interface ICredentials
{

	// Methods
	public abstract virtual NetworkCredential GetCredential(System.Uri uri, string authType) {}
}

