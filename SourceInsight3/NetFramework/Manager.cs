public class Manager : IHostEx
{

	// Constructors
	public Manager() {}

	// Methods
	public static string GetSiteName(string pURL) {}
	public static bool IsValidURL(string pURL) {}
	public static string CanonizeURL(string pURL, URL_CANONFLAGS flags) {}
	public static bool AreTheSame(string pURL1, string pURL2) {}
	public static bool AreOnTheSameSite(string pURL1, string pURL2) {}
	public static bool GetCodeBase(string pURLout , System.String& codeBaseout , System.String& application) {}
	public static bool GetConfigurationFile(string pURLout , System.String& pathout , System.String& file) {}
	public static string MakeFullLink(string link, string CodeBase, string Application) {}
	public static byte[] DecodeDomainId(string hexString) {}
	public virtual ISecureFactory GetSecuredClassFactory(int flags, int zone, string site, string uniqueIdString, string fileHashString, string typeName, string assemblyName) {}
	public virtual ISecureFactory GetClassFactory(string assemblyName, string className) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int INTERNET_MAX_PATH_LENGTH;
	public int INTERNET_MAX_SCHEME_LENGTH;
	public int INTERNET_MAX_URL_LENGTH;
}

