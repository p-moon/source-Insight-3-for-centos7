public class FormsAuthentication
{

	// Constructors
	public FormsAuthentication() {}

	// Methods
	public static string HashPasswordForStoringInConfigFile(string password, string passwordFormat) {}
	public static void Initialize() {}
	public static FormsAuthenticationTicket Decrypt(string encryptedTicket) {}
	public static string Encrypt(FormsAuthenticationTicket ticket) {}
	public static bool Authenticate(string name, string password) {}
	public static void SignOut() {}
	public static void SetAuthCookie(string userName, bool createPersistentCookie) {}
	public static void SetAuthCookie(string userName, bool createPersistentCookie, string strCookiePath) {}
	public static System.Web.HttpCookie GetAuthCookie(string userName, bool createPersistentCookie) {}
	public static System.Web.HttpCookie GetAuthCookie(string userName, bool createPersistentCookie, string strCookiePath) {}
	public static string GetRedirectUrl(string userName, bool createPersistentCookie) {}
	public static void RedirectFromLoginPage(string userName, bool createPersistentCookie) {}
	public static void RedirectFromLoginPage(string userName, bool createPersistentCookie, string strCookiePath) {}
	public static FormsAuthenticationTicket RenewTicketIfOld(FormsAuthenticationTicket tOld) {}
	public static void RedirectToLoginPage() {}
	public static void RedirectToLoginPage(string extraQueryString) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string FormsCookieName { get{} }
	public string FormsCookiePath { get{} }
	public bool RequireSSL { get{} }
	public bool SlidingExpiration { get{} }
	public System.Web.HttpCookieMode CookieMode { get{} }
	public string CookieDomain { get{} }
	public bool EnableCrossAppRedirects { get{} }
	public bool CookiesSupported { get{} }
	public string LoginUrl { get{} }
	public string DefaultUrl { get{} }
}

